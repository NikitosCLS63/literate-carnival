   M S B A M L   `   `   `  ����H  DPRR5AVTOsalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PRR5AVTOsalonPRR5AVTOsalon  5          PRR5AVTOsalon.prodovec   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:PRR5AVTOsalon     5        � Title$  prodovec��5	      $	��340��6   $	��550��6&   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5    
   �� $��Tovar v dostp��6   $
��Left=�6+   $	��Top=�6F   $��0��6^   $��Algerian)�6n   �� 5!   
   $��Tovar Vibran��6   $��20��6)   $��99��65   $
��Left=�6@   $��Algerian)�6[   $	��Top=�6q   $��2��6�   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ prodovecDgr��5"   z      AutoGenerateColumns .  $	��210��6/   $	��260��6<   $
��Left=�6H      CanUserAddRows .  $��8��6�   $��1��6�      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Marka��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *<:Avtomobili.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki+  5&      $ Model��6%    64   �� *-+Avtomobili.ModeliAvtomobila.NazvaniyeModeli+  5'      $ God Vipuska��6%    6:   �� *Avtomobili.Godvipuska+  5(      $ Price��6%    64   �� *Avtomobili.Price+5*      �� 5+   
   $��Marka��6   $��2��6!   $��1��61   $��Algerian)�6>   �� 5,   
   -   5        	 ��Name$	 markabox��5,      $��2��6$   $��2��64   $��30��6A   $	��150��6M   
 �� 	MaxLength$
 30��6Z   $
��Left=�6i   �� 5-   
   $��Model��6   $��2��6!   $��3��61   $��Algerian)�6>   �� 5.   
   -   5        $	 modelbox��5.      $��2��6$   $��4��64   $��30��6A   $
 30��6N   $	��150��6]   $
��Left=�6i   �� 5/   
   $��Price��6   $��2��6!   $��5��61   $��Algerian)�6>   �� 50   
   -   5        $	 pricebox��50      $��2��6$   $��6��64   $
 15��6B   $��30��6Q   $	��150��6]   $
��Left=�6i   �� 51   
   -   5         ��Name$
 Chek��51   *   $ ��Чек и закрытие��6   $��2��68   $��9��6H   $	��100��6U   $��20��6a   $��Right=�6m   �� 52   
   -   5        $	 	sdachabox��52      $��2��6%   $��8��65   $	��100��6B   $��20��6N   $��Right=�6Z   �� 53   
   $��Sdacha��6   $��Algerian)�6"   $��2��69   $��8��6I   {�.  $
��Left=�6h   �� 54   
   -   5        $
	 dali��54      $��2��6    $��7��60   $	��100��6=   $��20��6I   $��Right=�6U   �� 55   
   $
��Dano��6   $��Algerian)�6    $��2��67   $��7��6G   $
��Left=�6T   �� 56   
   -   5        $��Close��56      $��0��6!   $��9��61   6>   58      5;      