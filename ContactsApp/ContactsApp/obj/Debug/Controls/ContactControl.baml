   M S B A M L   `   `   `  ����F  BContactsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ContactsAppContactsApp  5           ContactsApp.ContactControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ContactsApp     5      .��5	      � ���	#AAE5E5E5  � ColumnDefinitions  5
   
   �� 5      $	��110 �6   �� 5      $	��100 �6   �� 5      $	��350 �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��30(�6.    �� Padding$ 13q�6<    �� TextAlignment$ Center=�6I   $��70��6`   $��70��6k   $��Center=�6x   $��Center=�6�   $��0��6�   $��0��6�   $��3��6�   
���iii�$��5q�6�   
���������6   �� *
Initials+6�   �� 5   
   -   5         ��Name$ nameCard��5      $��20(�6<   $
��Bold"�6J   $��1��6\   $��0��6l   ��6&   �� *Name+6l   �� 5   
   -   5        $ surnameCard��5      $��20(�6B   $
��Bold"�6P   $��2��6b   $��0��6r   ��6)   �� *	Surname+6r   �� 5   
   -   5        $ 	emailCard��5      $��15(�6>   
������$��1��6d   $��2��6t   $��1��6�   ��6'   �� *Email+6�   �� 5   
   -   5        $ 	phoneCard��5      $��15(�6>   $��Italic$�6L   $��1��6_   $��2��6o   $��2��6�   ��6'   �� *Phone+6�   �� 5   
   $��Details/Update��6   $	��100��6*   $��20��66   $��Center=�6C   $��Right=�6^   $��3��6z   $��0��6�   �� 5   
   $��Delete��6   $	��100��6"   $��20��6.   $��Center=�6;   $��Right=�6V   $��3��6r   $��1��6�   5      5      