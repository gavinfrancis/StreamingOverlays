   M S B A M L   `   `   `  ???? G  CShinyHunting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ShinyHuntingShinyHunting      ShinyHunting.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  &localclr-namespace:ShinyHunting  -   $
??1080??$
??1920??  ? WindowStyle$
  None=? ? AllowsTransparency$
 True??
?????? .???? -    ??Name$ 
RootLayout??$
??1920??$
??1080??.+?>? -   ?? $
??Fill=????? *VerticalBorderWidth+???? *VerticalBorderHeight+
 ?? Top ?? *(&ScreenOne_LeftVerticalBorder_PositionY+ ?? Left ?? *(&ScreenOne_LeftVerticalBorder_PositionX+???? *
BorderType+?? $
??Fill=????? *VerticalBorderWidth+???? *VerticalBorderHeight+ ?? *)'ScreenOne_RightVerticalBorder_PositionY+ ?? *)'ScreenOne_RightVerticalBorder_PositionX+???? *
BorderType+?? $
??Fill=????? *HorizontalBorderWidth+???? *HorizontalBorderHeightTop+ ?? *+)ScreenOne_UpperHorizontalBorder_PositionY+ ?? *+)ScreenOne_UpperHorizontalBorder_PositionX+???? *
BorderType+?? $
??Fill=????? *HorizontalBorderWidth+???? *HorizontalBorderHeightBottom+ ?? *+)ScreenOne_LowerHorizontalBorder_PositionY+ ?? *+)ScreenOne_LowerHorizontalBorder_PositionX+???? *
BorderType+?? $
??Fill=????? *VerticalBorderWidth+???? *VerticalBorderHeight+ ?? *(&ScreenTwo_LeftVerticalBorder_PositionY+ ?? *(&ScreenTwo_LeftVerticalBorder_PositionX+???? *
BorderType+?? $
??Fill=????? *VerticalBorderWidth+???? *VerticalBorderHeight+ ?? *)'ScreenTwo_RightVerticalBorder_PositionY+ ?? *)'ScreenTwo_RightVerticalBorder_PositionX+???? *
BorderType+?? $
??Fill=????? *HorizontalBorderWidth+???? *HorizontalBorderHeightTop+ ?? *+)ScreenTwo_UpperHorizontalBorder_PositionY+ ?? *+)ScreenTwo_UpperHorizontalBorder_PositionX+???? *
BorderType+?? $
??Fill=????? *HorizontalBorderWidth+???? *HorizontalBorderHeightBottom+ ?? *+)ScreenTwo_LowerHorizontalBorder_PositionY+ ?? *+)ScreenTwo_LowerHorizontalBorder_PositionX+???? *
BorderType+?? $
??Fill=?$ 0?? ?? *#!CroppedGraphicSideLeft_Position_X+???? *LeftCroppedGraphic+ J? Clip ??  ?? Rect ?? *CroppedGraphicSide+?? $ 0?? ?? *%#CroppedGraphicMiddleLeft_Position_X+???? *LeftCroppedGraphic+ ??  ?? *CroppedGraphicMiddle+?? $ 0?? ?? *&$CroppedGraphicMiddleRight_Position_X+???? *RightCroppedGraphic+ ??  ?? *CroppedGraphicMiddle+?? $ 0?? ?? *$"CroppedGraphicSideRight_Position_X+???? *RightCroppedGraphic+ ??  ?? *CroppedGraphicSide+?? $
??Fill=????? *GraphicWidth+???? *GraphicHeight+ ?? *GraphicOne_PositionY+ ?? *GraphicOne_PositionX+???? *LeftGraphic+?? $
??Fill=????? *GraphicWidth+???? *GraphicHeight+ ?? *GraphicTwo_PositionY+ ?? *GraphicTwo_PositionX+???? *RightGraphic+?? ???? *PokeballGraphicWidth+???? *PokeballGraphicHeight+ ?? *PokeBallGraphicLeft_PositionY+ ?? *PokeBallGraphicLeft_PositionX+???? *PokeBallGraphic+z???  ?? ScaleX$ -1Q??? ???? *PokeballGraphicWidth+???? *PokeballGraphicWidth+ ?? * PokeBallGraphicRight_PositionY+ ?? * PokeBallGraphicRight_PositionX+???? *PokeBallGraphic+?? $
??Fill=????? *PokemonOneWidth+???? *PokemonOneHeight+ ?? *Pokemon_1_PositionY+ ?? *Pokemon_1_PositionX+"  WpfAnimatedGif.ImageBehavior   AnimatedSource ?? *CurrentPokemonOne+z??? $ -1Q??? $
??Fill=????? *PokemonTwoWidth+???? *PokemonTwoHeight+ ?? *Pokemon_2_PositionY+ ?? *Pokemon_2_PositionX+ ?? *CurrentPokemonTwo+?? -   	 ??Name$	 currentCount??$??32(?$??Center=?$??Center=?
??????????? *
FontType+???? *CurrentCountOne+???? *TextCounterWidth+???? *TextCounterHeight+ ?? *TextCounterLeft_PositionX+ ?? *TextCounterLeft_PositionY+?? -   $	 currentCount2??$??32(?$??Center=?$??Center=?
??????????? *
FontType+???? *CurrentCountTwo+???? *TextCounterWidth+???? *TextCounterHeight+ ?? *TextCounterRight_PositionX+ ?? *TextCounterRight_PositionY+