   M S B A M L   `   `   `  ����M  IGUI Implementation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GUI_ImplementationGUI_Implementation  5          GUI_Implementation.About   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:GUI_Implementation     5        N� Title$  About��5	       � 	Resources 5
         
BlueButton �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� 
StartPoint	 �� EndPoint
 � Color � Offset T� X T� Y �� Triggers P� Property P� Value �� 
TargetName��%�  &	        �� 5   
   " ��6#   .�5      ��  � ��$	 190��6&   �� 5       � ��$ 40��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   #��z��6?   }�. .+�5      �� $ 
background��6%   $ 20��69   
����  �$��3q�6b   ��5   "   �� 5   &   $	 0,0&�6:   $		 0,1&�6K   .��5   *   � $
 	AliceBlue��67   $	 0.2Q�6I   � 5   *   $
 	LightBlue��67   $
 0.85Q�6I   � 5   *   $
 LightSkyBlue��67   $ 1Q�6L   5   '   5      �� 5      $��contentShadow��6g   $��Center=�6/   $��Center=�6L   z�5   "   T� 5   &   $	 0.5Q�69   $	 0.5Q�6A   5       �� 5!      $��content��6g   $��Center=�6/   $��Center=�6L   6g   5"       5#      P� 5$       � �� . . �5%   "   �� $ content��6)    � z� 5&   &   T� 5'   *   $	 2.0Q�6=   5*   #   5+      P� 5,       �@J�IsMouseOver . . �5-   "   �� $ 
background��6)    � �� 5.   &   �� 5/   *   $	 0.5,1&�6>   $ 0.5,0&�6O   .��50   .   � $
 	LightGray��6;   $ 0Q�6M   � 51   .   $

 Gray��6;   $ 1Q�6H   52   +   54   #   56      59      5;      5<      5>      .��5?      �� 
�������.+�5@   
   � .+�5B      o� $
��Left=�6   $	��Top=�6.   $	��800��6F   $��15(�6R   .@�5C      m� -   5        $
��Home��5C      6)   m� 5D      $
��File��6   .@�5E      m� -   5        $	��New��5E      $
��Left=�6,   $	��140��6G   5F      m� 5H      -   5        $
��Open��5H      $
��Left=�6-   $	��140��6H   5I      �� 5K      $
��Left=�6    $	��140��6;   m� 5L      -   5        $
��Help��5L      $
��Left=�6-   $	��140��6H   5M      �� 5O      $
��Left=�6    $	��140��6;   m� 5P      -   5        $��Close��5P      $
��Left=�6.   $	��140��6I   5Q      5R      m� 5T      -   5        $
��Help��5T      .@�5U      m� -   5        $��
Contact Us��5U      63   5V      5Y      �� 5[      -   5         ��Name$ NewLabel��5[      $��About Us��6&   $
��Left=�69   $��100,60,-56,0q�5\      $	��Top=�6&   $	��100��6>   $	��630��6K   $��Century Gothic)�5]      $��40(�6,   $��Normal$�5^      $��DemiBold"�6#   
����  �69   A� 5_      $	��150��6   $	��150��6$   $��Center=�61   $��-400,140,0,0q�6P   ��5`      �� 5a       �� ImageSource$ aboutUs.jpg��6!   5c      �� 5d      -	   5         ��Name$ aboutDev��5d      $
��Left=�6*   $	��100��6G   $��350,140,0,0q�5e   
   $
��Wrap=�6!   $��Italic$�67   $��DemiBold"�6J   $��24(�6`   $A��;May Trinh 
Creator of MortgageCalculator.com 
UI Developer
��5f   
   5g      � 5h   
   .+�5i      �� -
   5        $ aboutUs��5i      $
��Left=�6)   $	��620��6F   $��
100,20,0,0q�5j   
   $
��Wrap=�6    $��Italic$�66   $��20(�6I   $����At some point in every person's life, important financial decision will need to be made. Financial decision might seem intimidating and scary to deal with. But don't worry, whether you intend to purchase a home or refinance a car, MortgageCalculator.com is here to help you.

MortgageCalculator.com helps you break down what your mortgage payments will be with varying interest rate and length. We also offer a tool allow you to apply extra principle payment to speed up your mortgage pay-off based on the frequency of the payment and calculate the current balance accordingly.

  	MortgageCalculator.com is happy to make your finacial decision a lot easier!��5k   
   5p      5q      � 5r   
   .+�5s      �� -   5        $ contactLabel��5s      $��
Contact Us��6*   $
��Left=�6?   $��100,30,-56,0q�5t      $	��Top=�6&   $	��100��6>   $	��630��6K   $��Century Gothic)�5u      $��40(�6,   $��Normal$�5v      $��DemiBold"�6#   
����  �69   �� 5y      -   5        $ contactBlock��5y      $
��Left=�6.   $	��620��6K   $	��100��6W    �� TextAlignment$ Center=�6d   $��
70,100,0,0q�5z   
   $
��Wrap=�6    $��Italic$�66   $��25(�6I   
�������$<��6Phone: XXX-XXX-XXX 
Email: help@mortgagecalculator.com��5{   
   5}      �� 5   
   -   5        $��60��5      $��50��6   $��2��6(   $��
480,20,0,0q�68    ^� ToolTip$ Return��6e   #��[  5�      .��5�      F� 
���   �"������- ��- � � ��O���- @�q	 J� RenderTransformOrigin$ 
0.66,0.503&�6>    �� Stretch$
 Fill=�6a   $��17.964��6p   $��40.015��6   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�       �� Angle$ 180.222Q�6*   T� 5�      $ -7.033Q�6-   $ -0.278Q�68   5�      5�      5�      5�      5�      