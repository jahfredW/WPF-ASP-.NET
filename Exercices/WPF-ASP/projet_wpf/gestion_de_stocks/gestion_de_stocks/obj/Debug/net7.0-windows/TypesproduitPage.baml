   M S B A M L   `   `   `  ����L  Hgestion_de_stocks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:gestion_de_stocksgestion_de_stocks  5   	   (    "gestion_de_stocks.TypesproduitPage   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:gestion_de_stocks     5   	     � Title$  TypesproduitPage��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $
��260* �6   �� 5      $	��10* �6   �� 5      $
��143* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $
��386* �6   �� 5      $��9* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_typesproduit��5      $��1��6-   $��1��6=      AutoGenerateColumns$ False��6J      
IsReadOnly$
 True��6f      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $
��test��6%   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   	   
Visibility$	 Hidden=�6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *IdTypesProduits+6V     5       $ Libelle��6%   
 66   �� *LibelleTypeProduit+5"      5&      5'      