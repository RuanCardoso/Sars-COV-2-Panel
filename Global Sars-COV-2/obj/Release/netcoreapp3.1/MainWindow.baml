   M S B A M L   `   `   `  ���� L  HGlobal Sars-COV-2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Global_Sars_COV_2Global_Sars_COV_2  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf "    Global_Sars_COV_2.MainWindow   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Global_Sars_COV_2     V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullY	 UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  	 @lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  	 (  "MahApps.Metro.Controls.MetroWindow    	GlowBrush
  �   �$��0q� � WindowStyle$ SingleBorderWindow=� � Title$ Global Sars-COV-2��$	��423��$	��616�� � WindowStartupLocation$ CenterScreen=�
������� � 
ResizeMode$ NoResize=�.��� .+�#  MaterialDesignThemes.Wpf.Card  -     Name$ 	cardinfor��$
��Left=�$��10,2,0,0q�$	��Top=�$	��185��$	��319��
�������
�������.��� .+��� -   $��Center=�$	��299��$��0,58,0,0q�$	��Top=����	#4C000000���	#05000000$��1,1,1,1q�$��6,6,6,6q� �� SelectedIndex$ 0��.@��� -    ��Name$ global��$��Global���� -   $ brasil��$��Brasil���� -   $	 eua��$	��EUA���� �� $��BR- São Paulo���� $��BR - Rio de Janeiro���� $��
BR - Pará���� $��Coronavírus (COVID-19)��$��Center=�$��0,5,0,0q�$	��Top=�$	��255��$��39��$��20(�$��SemiBold"�$��Global Sans Serif)��� -    ��Name$ 	separator��$����_______________________________________________________________________________________________________________________________________________________________________��$��Center=�$��0,25,0,0q�$	��Top=����	#4C000000$	��328��$��LeftToRight=��� -   $ confirmados��$��Confirmados��$
��Left=�$��	10,92,0,0q�$	��Top=�$��Light"��� -   $ 
separator1��$��_____________________��$
��Left=�$��
77,120,0,0q�$	��Top=�$��14(�	 J� RenderTransformOrigin$	 0.5,0.5&����	#4C000000z�V� .~��� �� �� 
 �� Angle$
 90Q�T� �� -	   $ separator1_Copy��$��_____________________��$
��Left=�$��177,120,0,0q�$	��Top=�$��14(�$	 0.5,0.5&����	#4C000000z�V� .~��� �� �� $
 90Q�T� �� -
   $ recuperados��$��Recuperados��$
��Left=�$��
111,92,0,0q�$	��Top=�$��Light"��� -   $ Mortos��$��Mortos��$
��Left=�$��
211,92,0,0q�$	��Top=�$��Light"��� -   $ fonte��$��Fonte: Google��$
��Left=�$��	2,161,0,0q�$	��Top=�$��SemiBold"�$��Italic$��� -   $ 	totalConf��$��Carregando...��$
��Left=�$��
10,124,0,0q�$	��Top=�$��SemiBold"�$��14(��� -   $ totalRec��$��Carregando...��$
��Left=�$��111,124,0,0q�$	��Top=�$��SemiBold"�$��14(��� -   $ totalMortos��$��Carregando...��$
��Left=�$��211,124,0,0q�$	��Top=�$��SemiBold"�$��14(�$	 0.497,0.678&��� -    ��Name$ close��$��X��$
��Left=�$��602,-28,0,0q�$	��Top=�$��12��$��13��$��Center=�$��Center=�$��0,0,0,0q�$��10(�
���  ��
���  ��  $
��Left=�$��	337,2,0,0q�$	��Top=�$	��371��$	��272��
�������
�������$��0,0,0,0q�.���� -    ��Name$ sobre��$
��Left=�$��	10,10,0,0q�$��.............��$
��Wrap=�$	��Top=�$	 0.237,0.629&�  LiveCharts.Wpf.PieChart  &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�   	Hoverable$ False��$��10,192,287,10q�   DataTooltip Z�    Series   LiveCharts.Wpf.PieSeries    LiveCharts.Wpf.Series   Title$ 
São Paulo��   Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 3    
DataLabels$
 True��   
LabelPoint �� *
PointLabel+  $ Rio de Janeiro��$ 4 $
 True�� �� *
PointLabel+  $ Pará��$ 6 $
 True�� �� *
PointLabel+  $ Manaus��$ 2 $
 True�� �� *
PointLabel+