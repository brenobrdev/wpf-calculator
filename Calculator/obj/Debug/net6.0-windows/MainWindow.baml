   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     � Title$  
MainWindow��5   	   $	��525��6   $	��350��6)   ���#212124.��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ labelResult��5      $��0��5      $��0��5      $��4��5      $��Center=�5      $
��48px(�5      $��Right=�5       �� 5!   
   -   5         ��Name$ buttonAc��5!         buttonAllStyle#��[  5#      $��AC��5$      $��1��5%      $��0��5&      �� 5'   
   -   5        $ buttonNegative��5'      #��[  5)      $	��+/-��5*      $��1��5+      $��1��5,      �� 5-   
   -   5        $ buttonPercentage��5-      #��[  5/      $��%��50      $��1��51      $��2��52      �� 53   
   -   5        $ buttonDivide��53        operatorButtonStyle#��[ 55      $��/��56      $��1��57      $��3��58      �� 59   
   -   5        $ button7��59        numberButtonStyle#��[ 5;      $��7��5<      $��2��5=      $��0��5>      �� 5?   
   -   5        $ button8��5?      #��[ 5A      $��8��5B      $��2��5C      $��1��5D      �� 5E   
   -   5        $ button9��5E      #��[ 5G      $��9��5H      $��2��5I      $��2��5J      �� 5K   
   -	   5        $ buttonMultiply��5K      #��[ 5M      $��*��5N      $��2��5O      $��3��5P      �� 5Q   
   -
   5        $ button4��5Q      #��[ 5S      $��4��5T      $��3��5U      $��0��5V      �� 5W   
   -   5        $ button5��5W      #��[ 5Y      $��5��5Z      $��3��5[      $��1��5\      �� 5]   
   -   5        $ button6��5]      #��[ 5_      $��6��5`      $��3��5a      $��2��5b      �� 5c   
   -   5        $ buttonSubtract��5c      #��[ 5e      $��-��5f      $��3��5g      $��3��5h      �� 5i   
   -   5        $ button1��5i      #��[ 5k      $��1��5l      $��4��5m      $��0��5n      �� 5o   
   -   5        $ button2��5o      #��[ 5q      $��2��5r      $��4��5s      $��1��5t      �� 5u   
   -   5        $ button3��5u      #��[ 5w      $��3��5x      $��4��5y      $��2��5z      �� 5{   
   -   5        $ 	buttonAdd��5{      #��[ 5}      $��+��5~      $��4��5      $��3��5�      �� 5�   
   -   5        $ button0��5�      #��[ 5�      $��0��5�      $��5��5�      $��2��5�      $��0��5�      �� 5�   
   -   5        $ 	buttonDot��5�      #��[ 5�      $��.��5�      $��5��5�      $��2��5�      �� 5�   
   -   5        $ buttonEquals��5�      #��[ 5�      $��=��5�      $��5��5�      $��3��5�      5�      5�      