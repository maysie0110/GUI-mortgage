   M S B A M L   `   `   `  ����M  IGUI Implementation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GUI_ImplementationGUI_Implementation  5      !    GUI_Implementation.HomePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:GUI_Implementation     5        N� Title$   Mortgage Calculator - Home��5	       � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� 
StartPoint	 �� EndPoint
 � Color � Offset T� X T� Y �� Triggers P� Property P� Value �� 
TargetName��%"  '��       �� 5   
   " ��6   .�5      ��  � ��$	 350��6&   �� 5       � ��$ 80��6'   �� 5       � ��$ 20(�6)   �� 5       � ��$ Normal"�6+   �� 5       � ��$ Century Gothic)�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   #��z��6?   }�. .+�5      �� $ 
background��6%   $ 20��69   
����  �$��3q�6b   ��5   "   �� 5   &   $	 0,0&�6:   $		 0,1&�6K   .��5   *   � $
 	#FFFFD190��67   $	 0.2Q�6I   � 5   *   $
 Orange��67   $
 0.85Q�6F   � 5   *   $
 	#FFFFD190��67   $ 1Q�6I   5   '   5      �� 5      $��contentShadow��6g   $��Center=�6/   $��Center=�6L   z�5    "   T� 5!   &   $	 0.5Q�69   $	 0.5Q�6A   5#      �� 5$      $��content��6g   $��Center=�6/   $��Center=�6L   6g   5%       5&      P� 5'       � �� . . �5(   "   �� $ content��6)    � z� 5)   &   T� 5*   *   $	 2.0Q�6=   5-   #   5.      P� 5/       �@J�IsMouseOver . . �50   "   �� $ 
background��6)    � �� 51   &   �� 52   *   $	 0.5,1&�6>   $ 0.5,0&�6O   .��53   .   � $
 	AliceBlue��6;   $ 0Q�6M   � 54   .   $
 	LightBlue��6;   $ 1Q�6M   55   +   57   #   59      5<      5>      5?      5@      .��5A      � ��5C   
   �� 5D       �� ImageSource$ watermark.png��6   .+�5G   
   �� -   5         ��Name$ 	HomeLabel��5G      $��Mortgage Calculator��6#   $��Center=�6A   $��
33,100,0,0q�5H      $	��Top=�6$   $	��150��6<   $	��610��6I   $��Century Gothic)�5I      $��55(�6,   $��Normal$�5J      $��DemiBold"�6#   
����  �69   �� 5L   
   -   5        $��	CreateNew��5L   C   $��Center=�6   $��33,-100,0,0q�6.   $��Center=�6T   .��6�   Create New Mortgage Form5M   '   �� 5O   
   -   5        $
��Open��5O   B   $��Center=�6   $��
33,150,0,0q�6.   $��Center=�6N   .��6�    Open An Existing Mortgage Form5P   -   o� 5R   
   $
��Left=�6   $	��Top=�6*   $	��800��6B   $��15(�6N   .@�5S      m� $
��File��6   .@�5T      m� -   5        $	��New��5T      $
��Left=�6(   $	��140��6C   5U      m� 5W      -   5        $
��Open��5W      $
��Left=�6)   $	��140��6D   5X      �� 5Z      $
��Left=�6   $	��140��67   m� 5[      -   5        $
��Help��5[      $
��Left=�6)   $	��140��6D   5\      �� 5^      $
��Left=�6   $	��140��67   m� 5_      -   5        $��Close��5_      $
��Left=�6*   $	��140��6E   5`      5a      m� 5b      -   5        $
��Help��5b      .@�5c      m� -	   5        $��About��5c      6*   m� 5e      -
   5        $��
Contact Us��5e      6/   5f      5h      5i      5j      