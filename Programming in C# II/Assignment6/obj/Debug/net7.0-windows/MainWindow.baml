   M S B A M L   `   `   `  ����F  BAssignment6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment6Assignment6  5   	       Assignment6.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment6     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $��Open Invoice��5      61   m� 5      $��	Load Logo��6   ${�False��6.   �� 5      m� 5      $��Print��6   ${�False��6*   m� 5      $��Save As Image��6   ${�False��62   �� 5      m� 5      -   5        $
��Exit��5      6)   5      m� 5      $
��Help��6   6'   5      � 5   
   -   5         �Name$ InvoiceGrid��5      $��
10,21,10,0q�6$   .+�5      �� -   5         ��Name$ LabelCompanyName��5      $��LabelCompanyName��6.   $
��Left=�6I   $��	17,18,0,0q�6d   $	��Top=�6w   $	��237��6�   $��60��6�   $
��Bold"�6�   $��20(�6�   �� 5      -   5        $ LabelInvoiceNumber��5      $��Invoice number��60   $
��Left=�6I   $��	487,0,0,0q�6d   $	��Top=�6w   �� 5      -   5        $ LabelInvoiceDate��5      $��Invoice date��6.   $
��Left=�6E   $��
487,26,0,0q�6`   $	��Top=�6t   �� 5      -   5        $ LabelDueDate��5      $��Due date��6*   $
��Left=�6=   $��
487,52,0,0q�6X   $	��Top=�6l   &   System.Windows.Controls.DataGrid  5      -   5          Name$ InvoiceDataGrid��5         AutoGenerateColumns$ False��60   $��14,128,10,128q�6L      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 125 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Description+6^     5      $ Quantity��6)   $	 125 6X    6;   �� *
Quantity+6X     5      $ Price��6)   $	 125 6V    68   �� *	UnitPrice+6V     5       $ Tax (%)��6)   $	 125 6Y    6:   �� *
TaxPercent+6Y     5!      $ 	Total Tax��6)   $	 125 6Y    6<   �� *
TotalTax+6Y     5"      $ Total��6)   $	 125 6R    68   �� *Total+6R   5$      �� 5%      $��Address��6   $
��Left=�6&   $��
10,299,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   �� 5&      -	   5        $ LabelSenderStreet��5&      $��Label��6/   $
��Left=�6?   $��
10,320,0,0q�6Z   $	��Top=�6n   �� 5'      -
   5        $ LabelSenderZipCode��5'      $��Label��60   $
��Left=�6@   $��
10,339,0,0q�6[   $	��Top=�6o   �� 5(      -   5        $ LabelSenderCity��5(      $��Label��6-   $
��Left=�6=   $��
10,359,0,0q�6X   $	��Top=�6l   �� 5)      -   5        $ LabelSenderCountry��5)      $��Label��60   $
��Left=�6@   $��
74,359,0,0q�6[   $	��Top=�6o   �� 5*      -   5        $ Contact��5*      $��Contact��6%   $
��Left=�67   $��348,299,0,0q�6R   $	��Top=�6g   $��34��6   $��56��6�   $
��Bold"�6�   �� 5+      -   5        $ 
LabelTotal��5+      $��Total��6(   $
��Left=�68   $��619,349,0,0q�6S   $	��Top=�6h   	 J� RenderTransformOrigin$	 0.965,1.119&�6�   $
��Bold"�6�   �� 5,      -   5        $ LabelTotalNumber��5,      $��Label��6.   $
��Left=�6>   $��702,349,0,0q�6Y   $	��Top=�6n   ���	#FFCCC1C16�   (  "System.Windows.Controls.DatePicker  5-      -   5        
  Name$
 DateInvoiceDate��5-      $
��Left=�62   $��
619,27,0,0q�6M   $	��Top=�6a     5.      -   5        $
 DateDueDate��5.      $
��Left=�6.   $��
619,57,0,0q�6I   $	��Top=�6]   �� 5/      -   5        $ LabelRecipientName��5/      $��Label��60   $
��Left=�6@   $��	295,0,0,0q�6[   $	��Top=�6n   $	 -0.026,-0.576&�6�   �� 50      -   5        $  LabelRecipientPersonalName��50      $��Label��68   $
��Left=�6H   $��
295,26,0,0q�6c   $	��Top=�6w   �� 51      -   5        $ LabelRecipientStreet��51      $��Label��62   $
��Left=�6B   $��
295,48,0,0q�6]   $	��Top=�6q   �� 52      -   5        $ LabelRecipientZipCode��52      $��Label��63   $
��Left=�6C   $��
295,69,0,0q�6^   $	��Top=�6r   �� 53      -   5        $ LabelRecipientCity��53      $��Label��60   $
��Left=�6@   $��
333,69,0,0q�6[   $	��Top=�6o   �� 54      -   5        $ LabelRecipientCountry��54      $��Label��63   $
��Left=�6C   $��
295,95,0,0q�6^   $	��Top=�6r   �� 55      -   5        $ LabelTelephone��55      $��Label��6,   $
��Left=�6<   $��348,320,0,0q�6W   $	��Top=�6l   �� 56      -   5        $ LabelURL��56      $��Label��6&   $
��Left=�66   $��348,344,0,0q�6Q   $	��Top=�6f   �� 57      -   5        $ LabelInvoiceNumberValue��57      $��Label��65   $
��Left=�6E   $��	616,1,0,0q�6`   $	��Top=�6s   $	 -0.105,0.425&�6�   $
��Bold"�6�   ���	#FFE41A1A6�   �� 58      -   5        $ LabelDiscount��58      $��Discount��6+   $
��Left=�6>   $��619,320,0,0q�6Y   $	��Top=�6n   �� 59      -   5         ��Name$ TextBoxDiscount��59      $
��Left=�6/   $��702,325,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $��38��6�   $��19��6�   ���	#FFCCC1C16�   5:      5>      5@      