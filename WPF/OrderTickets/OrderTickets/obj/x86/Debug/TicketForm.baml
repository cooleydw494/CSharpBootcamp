   M S B A M L   `   `   `  ����G  COrderTickets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:OrderTicketsOrderTickets  5   	       OrderTickets.TicketForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2ticketOrderclr-namespace:OrderTickets     5   	     � Title$  Ticket Orders��5   	   $	��250��6   $	��480��6,    � 
ResizeMode$ NoResize=�68    � 	Resources 5        OrderTickets.TicketOrder   	orderData*   $OrderTickets.PrivilegeLevelConverter  privilegeLevelConverter  
errorStyle �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� Self
 �� RelativeSource �� Path��%  &	        &	      &	 &       5   
   6"     5   
   6.   �� 5	   
   " ��6#    5
      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 60   �� #
 Z	 $) #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      � .+�5   
   ]� -   5        $��
dockPanel1��5      $��34��6&   $	��Top=�62   $��0q�6J   .+�5      o� -   5        $��menu1��5      $��22��6   $
��Auto��6,   $	��Top=�69   .@�5      m� $��_File��6   .@�5      m� -   5        $��purchaseTickets��5   2   $��	_Purchase��6   6I   m� 5      -   5        $
��exit��5   .   $��E_xit��6   6:   5      5      5      �� 5   
   -   5        $��label1��5   [   $��Event:��6   $��28��6!   $
��Left=�6-   $��	21,24,0,0q�6H   $	��Top=�6i   $	��120��6�   �� 5   
   -   5        $��	eventList��5   r   #��[ 6   $��23��67   $
��Left=�6C   $��
156,29,0,0q�6^   $	��Top=�6�   $	��205��6�    �� Text 5      �� 5       �� Source# [  6   $ 	EventName�6>    �� UpdateSourceTrigger$ Explicit=�6O    �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5      5!      @�5#      �� 5$      .��6    Party in Great Shevington Park5&      �� 5'      .��6   Daytrip to Upper Gumtree5)      �� 5*      .��6   Little Mudford Festival5,      �� 5-      .��6   Downley Hatch Summer Banquet5/      51      �� 52   
   -   5        $��label2��52   h   $��Customer Reference:��6   $��28��6.   $
��Left=�6:   $��	21,73,0,0q�6U   $	��Top=�6v   $	��120��6�   �� 53   
   -   5        $��customerReference��53   q   #��[ 6   $��23��66   $
��Left=�6B   $��
156,78,0,0q�6]   $	��Top=�6�   $	��205��6�   .��6�   ��54      �� 55      # [  6   $ CustomerReference�6>   $ Explicit=�6W    56        57      59      .��5:      5;      �� 5<   
   -	   5        $��label3��5<   f   $��Privilege Level:��6   $��28��6+   $
��Left=�67   $��
21,120,0,0q�6R   $	��Top=�6t   $	��120��6�   �� 5=   
   -
   5        $��privilegeLevel��5=   s   #��[ 6   $��23��67   $
��Left=�6C   $��156,125,0,0q�6^   $	��Top=�6�   $	��205��6�    5>      �� 5?      # [  6   $ PrivilegeLevel�6>    �� 	Converter# [ 6T   $ Explicit=�6�    5@        5A      5C      @�5E      �� 5F       �� 
IsSelected . .��61   
Standard5H      �� 5I      .��6   	Premium5K      �� 5L      .��6   	Executive5N      �� 5O      .��6   Premium Executive5Q      5S      �� 5T   
   -   5        $��label4��5T   ^   $��Tickets:��6   $��28��6#   $
��Left=�6/   $��
21,165,0,0q�6J   $	��Top=�6l   $	��120��6�   �� 5U   
   -   5        $��numberOfTickets��5U   M   $��22��6   $
��Left=�6   $��156,171,0,0q�68   $	��Top=�6d   $	��205��6|    � SmallChange$ 1Q�6�    �� TickPlacement$ BottomRight=�6�    � Maximum$ 10Q�6�    �� IsSnapToTickEnabled .  � Value 5V      �� 5W      # [  6   $ NumberOfTickets�6>   $ Explicit=�6U    5X        5Y      5[      5]      �� 5^   
   -   5         ��Name$ tickets��5^      $
��Left=�6#   $��23��6>   $��370,170,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6t   $��25��6�    �� 
IsReadOnly . $��Right=�6�   .��6�   ��5_      �� 5`       �� ElementName$ numberOfTickets��6   $ Value�68   .��5a      5b      5c      5d      