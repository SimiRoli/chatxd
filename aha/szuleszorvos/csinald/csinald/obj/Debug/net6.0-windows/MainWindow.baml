   M S B A M L   `   `   `  ����B  >csinald, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:csinaldcsinald  5   	       csinald.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:csinald     5   	     � Title$  	ToDo List��5   	   $	��350��6   $	��500��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ todoTextBox��5      $��0��6'   $��10q�64   �� 5   
   -   5         ��Name$ todoListBox��5      $��1��6'   $��10q�64   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5   
   �� -   5        $	��Add��5      $��5q�6;   �� 5   
   -   5        $��Delete��5      $��5q�6A   �� 5   
   -   5        $
��Save��5      $��5q�69   �� 5   
   -   5        $
��Load��5      $��5q�69   5      5      5      