using MathGame.Model;
using MathGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MathGame.Game
{
    public class GameViewModel : BaseViewModel
    {
        private IPlayerRepository _repo;

        public RelayCommand SubmitCommand { get; private set; }
        public RelayCommand StartCommand { get; private set; }

        private Player _currentPlayer;

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
            set { SetProperty(ref _currentPlayer, value); }
        }

        private int _questionCount;

        public int QuestionCount
        {
            get { return _questionCount; }
            set { SetProperty(ref _questionCount, value); }
        }

        private string _operation;

        public string Operation
        {
            get { return _operation; }
            set { SetProperty(ref _operation, value); }
        }

        private string _equation;

        public string Equation
        {
            get { return _equation; }
            set { SetProperty(ref _equation, value); }
        }

        private int _numCorrect = 0;

        public int NumCorrect
        {
            get { return _numCorrect; }
            set { SetProperty(ref _numCorrect, value); }
        }

        private int[] randNum = new int[2];

        private int? _input;

        public int? Input
        {
            get { return _input; }
            set { SetProperty(ref _input, value); }
        }

        private int _clock;

        public int Clock
        {
            get { return _clock; }
            set { SetProperty(ref _clock, value); }
        }

        //Create a new Dispatcher Timer
        DispatcherTimer timer;

        private bool _roundOver = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public GameViewModel(IPlayerRepository repo)
        {
            _repo = repo;
            SubmitCommand = new RelayCommand(SubmitAnswer, CanSubmitAnswer);
            StartCommand = new RelayCommand(OnStart, CanStart);

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(this.UpdateClock);
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            Clock++;
        }

        private void OnStart()
        {
            _roundOver = false;
            NumCorrect = 0;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            CreateEquation();
        }

        private bool CanStart()
        {
            return true;
        }

        private void SubmitAnswer()
        {
            if(Input.Equals(getCorrectAnswer()))
            {
                NumCorrect += 1;
            }
            Input = null;
            if (QuestionCount < 11)
                CreateEquation();
            else
                EndRound();
        }

        private bool CanSubmitAnswer()
        {
            if (!_roundOver)
                return true;
            return false;
        }

        private void EndRound()
        {
            timer.Stop();
            _roundOver = true;
            switch (Operation)
            {
                case "+":
                    if (NumCorrect >= CurrentPlayer.AddScore)
                    {
                        if (Clock < CurrentPlayer.AddTime)
                        {
                            CurrentPlayer.AddScore = NumCorrect;
                            CurrentPlayer.AddTime = Clock;
                        }
                    }
                    break;
                case "-":
                    CurrentPlayer.SubScore = NumCorrect;
                    CurrentPlayer.SubTime = Clock;
                    break;
                case "*":
                    CurrentPlayer.MultScore = NumCorrect;
                    CurrentPlayer.MultTime = Clock;
                    break;
                case "/":
                    CurrentPlayer.DivScore = NumCorrect;
                    CurrentPlayer.DivTime = Clock;
                    break;
            }
            _repo.UpdatePlayerAsync(CurrentPlayer);
        }

        private int getCorrectAnswer()
        {
            int answer = 0;
            switch (Operation)
            {
                case "+":
                    answer = randNum[0] + randNum[1];
                    break;
                case "-":
                    answer = randNum[0] - randNum[1];
                    break;
                case "*":
                    answer = randNum[0] * randNum[1];
                    break;
                case "/":
                    answer = randNum[0] / randNum[1];
                    break;
            }
            return answer;
        }

        private void CreateEquation()
        {
            generateRandNums();
            Equation = $"{randNum[0]} {Operation} {randNum[1]}";
            QuestionCount += 1;
        }

        internal void SetOperation(string operation)
        {
            Operation = operation;
        }

        internal void SetCurrentPlayer(Player player)
        {
            _currentPlayer = player;
        }

        private void generateRandNums()
        {
            Random random = new Random();
            if (Operation == "+")
            {
                randNum[0] = random.Next(0, 21);
                randNum[1] = random.Next(0, 21);
            }
            else if (Operation == "-")
            {
                do
                {
                    randNum[0] = random.Next(0, 21);
                    randNum[1] = random.Next(0, 21);
                }
                while (randNum[0] < randNum[1]);
            }
            else if (Operation == "*")
            {
                randNum[0] = random.Next(0, 13);
                randNum[1] = random.Next(0, 13);
            }
            else
            {
                do
                {
                    randNum[0] = random.Next(0, 16);
                    randNum[1] = random.Next(1, 16);
                }
                while (randNum[0] % randNum[1] != 0);
            }
        }
    }
}
