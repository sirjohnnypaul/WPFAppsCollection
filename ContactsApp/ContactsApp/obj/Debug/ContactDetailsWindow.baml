   M S B A M L   `   `   `  ����F  BContactsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ContactsAppContactsApp  5   	   &     ContactsApp.ContactDetailsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ContactsApp     5   	     � Title$  Contact Details��5   	   $	��450��6!   $	��410��6.   $	��410��6=   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
contactImg��5      $M��GC:\Users\sirjohnnypaul\Desktop\ContactsApp\ContactsApp\Images\user1.png��6$   $��70��6u   $��70��6�   $��0��6�   $��0��6�   � 5   
   $��1��6   $��0��6    .+�5      �� $
��Name��6   $��15(�6#   $��DemiBold"�61   $
��Left=�6G   �� 5      -   5         ��Name$ nameBox��5      $��Center=�6(   $��Center=�6D   $	��110��6b   $��5q�6o   ���	#AAE5E5E5$��0q�6�   $��4q�6�   5      � 5   
   $��2��6   $��0��6    .+�5      �� $��Surname��6   $��15(�6&   $��DemiBold"�64   $
��Left=�6J   �� 5       -   5        $ 
surnameBox��5       $��Center=�6+   $��Center=�6G   $	��110��6e   $��5q�6r   ���	#AAE5E5E5$��0q�6�   $��4q�6�   5!      �� 5"   
   -   5        $ initialsBox��5"      $��Center=�6(   $��Center=�6D   $	��110��6b   $��5q�6o   $��1��6z   $��1��6�   ���	#AAE5E5E5$��0q�6�   $��4q�6�   �� 5#   
   -   5        $ emailBox��5#      $��Center=�6%   $��Center=�6A   $	��241��6_   $��5q�6l   $��1��6w   $��2��6�   $��2��6�   ���	#AAE5E5E5$��0q�6�   $��4q�6�   �� 5$   
   -   5        $ phoneNumberBox��5$      $��Center=�6+   $��Center=�6G   $	��241��6e   $��5q�6r   $��1��6}   $��3��6�   $��2��6�   ���	#AAE5E5E5$��0q�6�   $��4q�6�   �� 5%   
   -   5        $ 	StreetBox��5%      $��Center=�6&   $��Center=�6B   $	��241��6`   $��5q�6m   $��1��6x   $��4��6�   $��2��6�   ���	#AAE5E5E5$��0q�6�   $��4q�6�   �� 5&   
   -   5        $ cityCodeBox��5&      $��Center=�6(   $��Center=�6D   $	��110��6b   $��5q�6o   $��1��6z   $��5��6�   ���	#AAE5E5E5$��0q�6�   $��4q�6�   �� 5'   
   -	   5        $ cityBox��5'      $��Center=�6$   $��Center=�6@   $	��110��6^   $��5q�6k   $��1��6v   $��6��6�   ���	#AAE5E5E5$��0q�6�   $��4q�6�   �� 5(   
   $��Initials��6   $��Center=�6$   $��Center=�6@   $	��110��6^   $��13(�6j   $��DemiBold"�6x   $��5q�6�   $��0��6�   $��1��6�   �� 5)   
   $��Email��6   $��Center=�6!   $��Center=�6=   $	��110��6[   $��13(�6h   $��DemiBold"�6v   $��5q�6�   $��0��6�   $��2��6�   �� 5*   
   $��Phone��6   $��Center=�6!   $��Center=�6=   $	��110��6[   $��13(�6h   $��DemiBold"�6v   $��5q�6�   $��0��6�   $��3��6�   �� 5+   
   $��Street��6   $��Center=�6!   $��Center=�6=   $	��110��6[   $��13(�6i   $��DemiBold"�6w   $��5q�6�   $��0��6�   $��4��6�   �� 5,   
   $
��City��6   $��Center=�6    $��Center=�6<   $	��110��6Z   $��5q�6g   $��0��6r   $��5��6�   $��13(�6�   $��DemiBold"�6�   �� 5-   
   $
��Code��6   $��Center=�6    $��Center=�6<   $	��110��6Z   $��5q�6g   $��0��6r   $��6��6�   $��13(�6�   $��DemiBold"�6�   �� 5.   
   -
   5         ��Name$ 	updateBtn��5.      $��Update��6$   $��1��6M   $��7��6]   $	��100��6j   $��20��6v   $��Center=�6�   
�����w�
�������$��Center=�6�   $��10(�6�   $��
ExtraLight"�6�   �� 5/   
   -   5        $ 	deleteBtn��5/      $��Delete��6$   $��2��6M   $��7��6]   $	��100��6j   
�����w�
�������$��20��6�   $��Center=�6�   $��Center=�6�   $��10(�6�   $��
ExtraLight"�6�   50      51      