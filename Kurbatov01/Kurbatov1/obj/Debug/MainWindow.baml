   M S B A M L   `   `   `  ����D  @Kurbatov1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Kurbatov01
Kurbatov01  5   	       Kurbatov01.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Kurbatov01     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��700��6)   
���   �.��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   (  "System.Windows.Controls.DatePicker  $��0��6   
���   �$��0��69      SelectedDate 6F   �� *	BirthDate+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   
�������$��0��67   $��20(�6D   $��Center=�6R   ��6o   �� *Age+$ OneWay=�$ PropertyChanged=��� 5   
   $��1��6   
�������$��1��67   $��20(�6D   $��Center=�6R   ��6o   �� *WesternZodiac+$ OneWay=�$ PropertyChanged=��� 5   
   $��1��6   
�������$��2��68   $��20(�6E   $��Center=�6S   ��6p   �� *ChineseZodiac+$ OneWay=�$ PropertyChanged=��� 5   
   $��4��6   $��0��6   $��Center=�6.   
�������$	��Run��6\   ��6j   �� *	RunButton+5      5      