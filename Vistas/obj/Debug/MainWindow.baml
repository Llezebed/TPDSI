   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	       Vistas.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Vistas     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  
MainWindow��5	   	   $	��600��6   $
��1024��6)    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[    � WindowStyle$
 None=�6q   
������  � AllowsTransparency . .��5      � -   5        .+�5   	   �  � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5      �� $	��250��6    �� CornerRadius$ 	25 0 0 25��6!   ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 0,1&�6;   .��5      � 	 � Color$	 #343155��6'   
 � Offset$
 0Q�67   � 5      $	 #3B2E58��6'   $
 1Q�67   5      5      �� 5      $ 	0 25 25 0��6   $��1��6.   ��5      �� 5      $	 0,0&�6*   $	 0,1&�6;   .��5      � $	 #3E3A65��6'   $
 0Q�67   � 5       $	 #473765��6'   $
 1Q�67   5!      5#      5$      � 5&   
    5'      �� 5(      $
��auto �6#   �� 5)      $��* �6#   .+�5,      �� $	��250��6   $
��Left=�6%   .+�5-      � .+�5.      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5.   :   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6]   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5/      � -   5         �Name$ 
GridCursor��5/      $��	0 100 0 0q�63   $��10��6F   $
��Left=�6Q   $��60��6l   $	��Top=�6x   ��50      �� 51   "   $ 0.5,0&�66   $ 0.5,1&�6I   .��52   &   � $	 #d489ff��63   $
 0Q�6C   � 53   &   $	 #7985ff��63   $	
 0.5Q�6C   � 54   &   $	 #6ad8fd��63   $
 1Q�6C   55   #   57      58      �� 59      -   5         ��Name$ ListViewMenu��59      $��0 100q�65   
�������$��Comic Sans MS)�6\   .@�5:      �� $��60��6'   .��5;      ��  �� Orientation$ 
Horizontal=�6)   .+�5<   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�6:   $��30��6F   $��30��6Q   $��Center=�6]   $��5q�6x   �� 5=   "   $��Inicio��6,   $��27(�6:   $��Center=�6H   $
��20 0q�6c   5>      5?      �� 5@      $��60��6'   .��5A      �� $ 
Horizontal=�6)   .+�5B   "     $ Update=�6:   $��30��6H   $��30��6S   $��Center=�6_   $��5q�6z   �� 5C   "   $/��)Importar Actualizacion de vinos de Bodega��6,   $��9(�6]   $��Center=�6j   $	��5 0q�6�   5D      5E      5F      5G      5H      �� 5J      $��1��6   .+�5K      �� $	��Top=�6   .+�5L      � $��15q�6   .+�5M      �� $��Right=�6%   .+�5N      �� -   5         ��Name$ 	BtnCerrar��5N   %   $��30��68   $��30��6C   $��0q�6|   
���������6O   Z� ��6e   Z� .��5O   "     $ Power=�6:   5P      5Q      5R      5S      � 5T      $��
20 55 20 0q�6   .+�5U      � -   5        $ GridPrincipal��5U      $��Center=�62   $	��Top=�6O   5V      5W      5X      5[      5\      