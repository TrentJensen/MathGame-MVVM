   M S B A M L   `   `   `  ����C  ?MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MathGameMathGame  5      %    MathGame.Players.PlayerListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:MathGame     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5      .  (System.Windows.Interactivity.Interaction    Triggers  5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      >  8Microsoft.Expression.Interactivity.Core.CallMethodAction     
MethodName$ LoadPlayers��6;      TargetObject 6"   �� 6;   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � .+�5      �� $��
Add Player��6   $
��Left=�5      ��5      �� *AddPlayerCommand+5      5      &   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns .     CanUserAddRows .  $��1��5          
IsReadOnly . ��5      �� *	Players+	 �� SelectedItem	 5"      �� *SelectedPlayer+  5#        5$      $ SelectionChanged��6!   . 5%        $ CheckCanContinue��6C    6*   �� 6C   5&      
   Columns
 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5*   %   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 5)   %   �� *	FirstName+5*   %   4
  .System.Windows.Controls.DataGridTemplateColumn
  5+      $
 Auto 6)    
  CellTemplate 5,      �� 5-      .R�5.      �� $
��Edit��6%   $��5q�51   %   ��5/   %   �� *DataContext.EditPlayerCommand+ �� RelativeSource ��  �� AncestorType"  ��50   %   �� 51   %   52      54      56      �� 57   
   $��2��6   $��Continue��58      $��Right=�5:      $��70��5;      ��59      �� *ContinueCommand+5;      5<      5=      