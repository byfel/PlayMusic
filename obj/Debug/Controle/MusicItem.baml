   M S B A M L   `   `   `  ����  Music Player%    Music_Player.Controle.MusicItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5        $��	musicItem��5      .��5      �� $��0 0 0 3q�6     �� CornerRadius$  5��6    �� Padding$ 7q�6/   ��5   
   �� 5	       �� 
TargetType" ��6    �� Triggers 5
      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  �� Property � �� �� Value
 ����67   5      �� 5       �� Binding 6"   �� 	 �� ElementName$	 	musicItem��
 �� Path$
 IsActive� �� Value true6Z   .a�5      ��  � ��
 ����67   5      5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� 
�������$��16(�6^   $��SemiBold"�6l   $��5 0 30 0q�6�   ��6   �� $	 	musicItem��$
 Number�6�   �� 5      $��1��6J   
�������$��16(�6m   $��SemiBold"�6{   $��0 0 0 2q�6�   ��6   �� $	 	musicItem��$
 Title�6�   �� 5      $��2��6J   
�������$��16(�6m   $��SemiBold"�6{   $��5 0 30 0q�6�   $��Right=�6�   ��6   �� $	 	musicItem��$

 Time�6�   5       5"      5#      