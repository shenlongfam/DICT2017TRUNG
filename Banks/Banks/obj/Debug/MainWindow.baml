   M S B A M L   `   `   `  ����@  <Banks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BanksBanks  5   	       Banks.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Banks     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblAccountNumber��5
      $��Account Number��6*   $
��Left=�6C   $��
236,17,0,0q�6^   $	��Top=�6r   �� 5   
   -   5        $ 
lblBalance��5      $��Balance��6$   $
��Left=�66   $��
285,58,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5         ��Name$ 	txtAccNum��5      $
��Left=�6%   $��23��6@   $��
360,20,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ 
txtBalance��5      $
��Left=�6&   $��23��6A   $��
360,61,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   	� 5   
   -   5         	�Name$ radWithdraw��5      $��Withdraw��6+   $
��Left=�6>   $��101,151,0,0q�6Y   $	��Top=�6n   	� 5   
   -   5        $ 
radDeposit��5      $��Deposit��6*   $
��Left=�6<   $��101,181,0,0q�6W   $	��Top=�6l   �� 5   
   $��Account Types��6   $
��Left=�6*   $	��100��6E   $��	87,17,0,0q�6R   $	��Top=�6e   $	��149��6}   .��5      � $
��Left=�6   $��80��6.   $��4,-6,0,0q�6:   $	��Top=�6L   $	��129��6d   .+�5      	� -   5        $ radCheckingAccount��5      $��Checking Account��6:   $
��Left=�6U   $��	10,10,0,0q�6p   $	��Top=�6�    J� RenderTransformOrigin$ -2.071,-0.792&�6�   	� 5      -   5        $ radSavingAccount��5      $��Saving Account��68   $
��Left=�6Q   $��	10,46,0,0q�6l   $	��Top=�6   5      5      �� 5   
   $��
Fund types��6   $
��Left=�6'   $	��100��6B   $��
86,131,0,0q�6O   $	��Top=�6c   $	��100��6{   .��5      � $
��Left=�6   $��80��6.   $��4,-6,0,0q�6:   $	��Top=�6L   $��80��6d   5      �� 5   
   -	   5         ��Name$ 
lstDisplay��5      $
��Left=�6&   $	��132��6A   $��198,145,0,0q�6N   $	��Top=�6c   $	��282��6{   �� 5   
   -
   5         ��Name$ 
btnDisplay��5      $
��Done��6%   $
��Left=�64   $��309,288,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ txtTransaction��5      $
��Left=�6*   $��23��6E   $��360,101,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ lblTransaction��5      $��Transaction Amount��6(   $
��Left=�6E   $��
219,98,0,0q�6`   $	��Top=�6t   5      5       