   M S B A M L   `   `   `  ���� K  GMGSV_SaveManager, Version=2.5.1.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MGSV_SaveSwitcherMGSV_SaveSwitcher  "    MGSV_SaveSwitcher.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:MGSV_SaveSwitcher       � Title$  MGSV Save Manager��$	��600�� � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterScreen=� � Cursor$  ��$	��650�� � Icon$ savemanager.ico��.����  �� Padding$ 10,20,10,10q�._��� .+��� $��Save Selection��$��16(�$��
10 0 10 20q�$
��Bold"�$��Center=�$$��Tw Cen MT Condensed Extra Bold)��� $��Status��$
��Bold"�$��12(�$��	10 0 10 0q�� $��0,0,0,15q� � ColumnDefinitions �� $��* ��� $��3* �.+��� $��0��$��	10 0 10 0q�$��Current User��$��Center=�$��12(��� -   $��currentUser��$��1��$��	10 0 10 0q� �� 
IsReadOnly . 
�������$��12(�$��Center=�$��Center=�� $��0,0,0,15q� �� $��* ��� $��3* �.+��� $��0��$��	10 0 10 0q�$��Current Save��$��Center=�$��12(��� -   $��currentSave��$��1��$�� ��$��	10 0 10 0q� . 
�������$��12(�$��Center=�$��Center=��� $��Change User��$
��Bold"�$��	10 0 10 0q��� $��Users��$��	10 0 10 0q�$��12(�� $��0,0,0,15q� �� $��2* ��� $��* �.+��� $��Users��$��	10 0 10 0q�$��12(��� -   $��userList��$��0��{�.  $��	10 0 10 0q�$��12(��� -   $��	applyUser��$��1��{�.  $��	10 0 10 0q�$��Apply��$��12(��� $��Change Save��$
��Bold"�$��	10 0 10 0q��� $��Saves��$��	10 0 10 0q�$��12(�� $��0,0,0,15q� �� $��2* ��� $��* �.+��� $��Saves��$��	10 0 10 0q�$��12(��� -   $��saveChangeList��$��0��{�.  $��	10 0 10 0q�$��12(��� -   $��applySaveChange��$��1��{�.  $��	10 0 10 0q�$��Apply��$��12(��� -   $��
RenameSave��$��Rename Save��$
��Bold"�$��
10 0 10 10q�� $��0,0,0,15q� �� $��2* ��� $��* �.+��� -   $��RenameSaveName��$��0��
������� . $��12(�$��	10 0 10 0q��� -	   $��ApplyRename��$��1��{�.  $��Apply��$��12(�$��	10 0 10 0q��� -
   $��firstNew��$��New Save��$
��Bold"�$��
10 0 10 10q�� $��0,0,0,15q� �� $��2* ��� $��* �.+��� -   $��newSaveName��$��0��
������� . $��12(�$��	10 0 10 0q��� -   $��applyNewSaveName��$��1��{�.  $��Apply��$��12(�$��	10 0 10 0q��� $��Delete Save��$
��Bold"�$��	10 0 10 0q��� $��Saves��$��	10 0 10 0q�$��12(�� $��0,0,0,15q� �� $	��38* ��� $
��345* ��� $
��191* �.+��� $��Saves��$��	10 0 10 0q�$��12(�$��2���� -   $��saveDelList��$��0��{�.  $��	10 0 10 0q�$��12(�$��2���� -   $��applyDelSave��$��2��{�.  $��	10 0 10 0q�$��Apply��$��12(�� $��0, 5, 0, 15q� �� $��* ��� $��3* �.+��� $��Steam directory��$��12(�$��	10 0 10 0q�$
��Bold"�$
��Left=��� -   $��	steamPath��$��1�� . 
�������$��12(�$��	10 0 10 0q��  �� $��* ��� $��2* �.+��� -   $��StartSaveScan��$��0��$��	Save Scan��{�.  $��	10 0 10 0q�$��12(�� $��0, 25, 0, 15q� �� $��* ��� $��2* ��� $��* �.+��� -   $��
BackWindow��$��1��$
��Back��{�. $��	10 0 10 0q�$��12(�