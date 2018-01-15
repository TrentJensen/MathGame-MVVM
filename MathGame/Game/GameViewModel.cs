using MathGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Game
{
    public class GameViewModel : BaseViewModel
    {
        public RelayCommand SubmitCommand { get; private set; }
        public RelayCommand StartCommand { get; private set; }

        private Player _currentPlayer;

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
            set { SetProperty(ref _currentPlayer, value); }
        }


        private string _operation;

        private int _questionCount;

        public int QuestionCount
        {
            get { return _questionCount; }
            set { SetProperty(ref _questionCount, value); }
        }

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

        private int _input;

        public int Input
        {
            get { return _input; }
            set { _input = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public GameViewModel()
        {
            SubmitCommand = new RelayCommand(SubmitAnswer, CanSubmitAnswer);
            StartCommand = new RelayCommand(OnStart, CanStart);
        }

        private void OnStart()
        {
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
            CreateEquation();
        }

        private bool CanSubmitAnswer()
        {
            if (QuestionCount < 11)
                return true;
            return false;
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
