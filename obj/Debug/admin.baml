   M S B A M L   `   `   `  ����H  DPRR5AVTOsalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PRR5AVTOsalonPRR5AVTOsalon  5          PRR5AVTOsalon.admin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:PRR5AVTOsalon     5        � Title$  admin��5	      $	��450��6   $	��800��6#   .��5      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ adminDGR��5   F      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id Sat��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *id+  5      $
 Name��6%    63   �� *
Nickname+  5      $ Surname��6%    66   �� *	Surname+  5      $ 
Middlename��6%    69   �� *
Middlename+  5      $ Parol��6%    64   �� *Parol+  5      $ idRoli��6%    65   �� *Rolu.NazvanieRolu+  5      $ LoginSat��6%    67   �� *
LoginSat+5      �� 5   
   $
��Name��6   �� 5   
   -   5         ��Name$ Namebx��5      $��20��6"   �� 5   
   $��Surname��6   �� 5   
   -   5        $ 	Surnamebx��5      $��20��6%   �� 5   
   $��
Middlename��6   �� 5   
   -   5        $ Middlenamebx��5      $��20��6(   �� 5   
   $��Parol��6   �� 5   
   -   5        $ Parolbx��5      $��20��6#    �� 	MaxLength$ 4��6/   �� 5   
   $
��Rolu��6   �� 5    
   -   5        $ Rolubx��5       $��20��6"   �� 5!   
   $��LoginSat��6   �� 5"   
   -   5        $ 
LoginSatbx��5"      $��20��6&   �� 5&   
   -   5        	 ��Name$		 Dob��5&      $��30��6   $��Dobavit��6*   6<   �� 5'   
   -	   5        
 ��Name$
 Filter��5'       �� DisplayMemberPath$ NazvanieRolu��6O    �� SelectedValuePath$ id��6q   5.      5/      