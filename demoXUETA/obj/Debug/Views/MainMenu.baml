   M S B A M L   `   `   `  ����D  @demoXUETA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:demoXUETA.ViewsdemoXUETA.Views  5   	       demoXUETA.Views.MainMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:demoXUETA.Views     5   	     � Title$  MainMenu��5   	   $	��450��6   $	��450��6'   $	��900��67   $	��900��6C   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��9* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   .+�5   
   � $��0��6    5      �� 5      �� 5      .+�5      �� -   5         ��Name$
 User��5      $��0��6&   $
��Left=�66   $��Center=�6Q   �� 5      -   5         ��Name$ 
CreateButn��5      $��Создать заказ��6)   $��1��6A   $��10 10 220 10q�6Q   6g   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 vivo��5      $��1��6!      AutoGenerateColumns .     
IsReadOnly .    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn	   Header$		 №��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 60   �� *id+  5"      $	 Дата создания��6%   
 6<   �� *date_create+  5#      $	 Вид техники��6%   
 6:   �� *Vid_texnika.name+  5$      $	 Модель��6%   
 65   �� *model_texnika+  5%      $'	 !Описание проблемы��6%   
 6@   �� *problem_description+  5&      $	 Фамилия��6%   
 66   �� *	surname+  5'      $	 Имя��6%   
 62   �� *name+  5(      $	 Отчество��6%   
 67   �� *
midllename+  5)      $!	 Номер телефона��6%   
 6=   �� *phone_number+  5*      $	 Статус заявки��6%   
 6<   �� *Status.name+4  .System.Windows.Controls.DataGridTemplateColumn  5,      $	 Действие��6)      CellTemplate 5-      �� 5.      .R�5/      �� $ editBut��6%   -   5        $/��)Редактировать/Удалить��5/   6   6V   50      52      57      58      59      