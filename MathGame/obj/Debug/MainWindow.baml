   M S B A M L   `   `   `  ����C  ?MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MathGame.GameMathGame.Game  5   	   3clr-namespace:MathGame.PlayersMathGame.Players  5   	   1clr-namespace:MathGame.ScoresMathGame.Scores  5   	   #clr-namespace:MathGameMathGame  5	   	       MathGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,gameclr-namespace:MathGame.Game     5   	   2playersclr-namespace:MathGame.Players     5   	   0scoresclr-namespace:MathGame.Scores     5   	   (localclr-namespace:MathGame     5	   	     � Title$  
MainWindow��5   	   $	��450��6   $	��725��6)    � DataContext 5      "  MathGame.MainWindowViewModel  5   
    � 	Resources 5       �� DataType*   $MathGame.Players.PlayerListViewModel%   MathGame.Players.PlayerListView'   !MathGame.Players.AddEditViewModel"   MathGame.Players.AddEditView!   MathGame.Game.GameViewModel   MathGame.Game.GameView'  !MathGame.Game.ChooseGameViewModel"	   MathGame.Game.ChooseGameView$
  MathGame.Scores.ScoreViewModel   MathGame.Scores.ScoreView��%w  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *,
 +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      �� 5   
   " 
 6   .R�5        5      5       .��5"      �  � RowDefinitions 5#   
   �� 5$      $
��Auto �6   �� 5%      $��* �6   .+�5'   
   � -   5         �Name$ NavBar��5'       � ColumnDefinitions 5(      �� 5)      $��* �6#   �� 5*      $��* �6#   �� 5+      $��* �6#   .+�5-      �� $��Players��6   $��player��5/      $��0��50      ��5.      �� *
NavCommand+50      �� 51      $��Scores��6   $��score��53      $��1��54      ��52      �� *
NavCommand+54      �� 55      $
��Play��6   $
��game��57      $��2��58      ��56      �� *
NavCommand+58      59      � 5:   
   -   5        $ MainContent��5:      $��1��6$    5;      �� 5<      $
��Auto �6    �� 5=      $��* �6    .+�5?      �� $��20(�64   ��6   �� *
PlayerName+64   �� 5@      $��1��6   ��6*   �� *CurrentViewModel+5A      5B      5C      