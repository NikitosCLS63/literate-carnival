   M S B A M L   `   `   `  ����H  DPRR5AVTOsalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PRR5AVTOsalonPRR5AVTOsalon  5          PRR5AVTOsalon.perekup   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:PRR5AVTOsalon     5        � Title$  perekup��5	      $	��450��6   $	��800��6%   .��5      �� .+�5   
   �  � RowDefinitions 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $��4* �6#   �� 5      .+�5      �� -   5         ��Name$ Naytibb��5      �� 5      -   5         ��Name$ Nayti��5   5   $��NAYTI��6   $��1��6%   6D   �� 5      -   5        $ Ochidtka��5   (   $��OCHISTKA��6   $��1��6:   $��1��6J   6W   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
perekupDGR��5   F      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Marka��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 64   �� *<:Avtomobili.ModeliAvtomobila.MarkaAvtomobila.NazvaniyeMarki+  5      $	 Model��6%   
 64   �� *-+Avtomobili.ModeliAvtomobila.NazvaniyeModeli+  5      $	 God Vipuska��6%   
 6:   �� *Avtomobili.Godvipuska+  5      $	 Price��6%   
 64   �� *Avtomobili.Price+  5       $	 Data Obslujivaniya��6%   
 6A   �� *Dataobslujivaniya+  5!      $	 OpisanieRabot��6%   
 6<   �� *Opisaniyerabot+5$      �� 5%   
   $��MARKA��6   $��16(�6"   $��Algerian)�60   �� 5&   
   -   5        $ 	VvodMarka��5&       �� 	MaxLength$ 30��6%   �� 5'   
   $��MODEL��6   $��16(�6!   $��Algerian)�6/   �� 5(   
   -   5        $ 
VvodModeli��5(      $ 30��6&   �� 5)   
   $��PRICE��6   $��16(�6!   $��Algerian)�6/   �� 5*   
   -   5        $ 	VvodPrice��5*      $ 15��6%   �� 5+   
   -   5        $ ViborBB��5+      �� 5,   
   -	   5         ��Name$ 
ViborModel��5,       �� DisplayMemberPath$
 name��6V   �� 5-   
   -
   5        $ Dobavit��5-   $   $��ДОБАВИТЬ��6   65   �� 5.   
   -   5        $ Izmenit��5.   $   $��ИЗМЕНИТЬ��6   65   �� 5/   
   -   5        $ Delete��5/   #   $��Удалить��6   63   �� 50   
   -   5        $ Clooose��50   !   $��Close��6   62   51      52      