   M S B A M L   `   `   `  ���� M  IImageEditorProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ImageEditorProjectImageEditorProject  $    ImageEditorProject.ImageEditor   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:ImageEditorProject     .��� 
�������  � ColumnDefinitions  �� $	��140 ��� �� ��  � RowDefinitions �� $��50 ��� $��50 ��� �� �� �� �� �� �� $��50 �.+�� $��0��$��0��$��4��  �� $��50 ��� $��50 ��� �� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� �� $��50 � �� .+��� -   $��Colors��$��0��$��Center=�$��0��$��40��$��40��.@��� $��Y���� $��P���� -   
�������
�������$��0��$��Center=�$��0��$��Center=�$��40��$��40�� � ToolTip$ Upload Image��.��]� .+��� $��25��$��25��$��/Assets/upload.png���� -   
�������
�������$��1��$��Center=�$��0��$��Center=�$��40��$��40��$
 Save��.��]� .+��� $��25��$��25��$��/Assets/diskette (1).png���� -   
�������
�������$��3��$��Center=�$��0��$��Center=�$��40��$��40��$ Pencil��.��]� .+��� $��25��$��25��$��/Assets/specialist.png���� -   
�������
�������$��4��$��Center=�$��0��$��Center=�$��40��$��40��$ Brush��.��]� .+��� $��25��$��25��$��/Assets/paint-brush.png���� -   
�������
�������$��5��$��Center=�$��0��$��Center=�$��40��$��40��$
 Text��.��]� .+��� $��25��$��25��$��/Assets/font.png���� -   
�������
�������$��6��$��Center=�$��0��$��Center=�$��40��$��40��$
 Move��.��]� .+��� $��25��$��25��$��/Assets/move.png���� -   
�������
�������$��7��$��Center=�$��0��$��Center=�$��40��$��40��$ Highlighter��.��]� .+��� $��25��$��25��$��/Assets/highlighter.png���� -	   
�������
�������$��8��$��Center=�$��0��$��Center=�$��40��$��40��$ 	Rectangle��.��]� .+��� $��25��$��25��$��/Assets/shapes.png���� -
   
�������
�������$��10��$��Center=�$��0��$��Center=�$��40��$��40��$
 Undo��.��]� .+��� $��25��$��25��$��/Assets/arrow-circle.png��� $��9��$��0��$��4��  �� �� $��50 ��� $��50 ��� $	��200 ��� $��50 ��� $��75 ��� .+��� -   $��
percentage��$��0��$��5��$��Center=�$��Center=��� -   $��
ZoomAmount��$��0��$��3��$��Center=� � Maximum$	 400Q��� -   
�������
�������$��4��$��Center=�$��0��$��Center=�$��40��$��40��$ Zoom In��.��]� .+��� $��25��$��25��$��/Assets/add.png���� -   
�������
�������$��2��$��Center=�$��0��$��Center=�$��40��$��40��$ Zoom Out��.��]� .+��� $��25��$��25��$��/Assets/minus.png���� -   
�������
�������$��1��$��Center=�$��0��$��Center=�$��40��$��40��$ Reset��.��]� .+��� $��25��$��25��$.��(/Assets/switch-to-full-screen-button.png��#   ImageEditorProject.ZoomBorder  -     Name$ border��}�. 
�������$��1��$��0��$��4��$��7��   Child. � -   $��	Component��.+��� -   $
��Back��$��Center=��� -   $��Drawing��$��Center=�����  �� Color$ White�� �� Opacity$ 0Q�� -   $��Brush��$��1��$��0��$��4��  �� �� ��  