using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;


namespace ShinyHunting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LayoutHelper LayoutSettings;

        // Constructor
        public MainWindow()
        {
            this.LayoutSettings = new LayoutHelper();

            DataContext = this;
            InitializeComponent();
        }

        // ********************************************************** //
        //                                                            //
        // Getters that are accessed within the Main Display Window   //
        //                                                            //
        // ********************************************************** //


        // Getters for Display Graphics Paths
        public string LeftGraphic { get { return this.LayoutSettings.GetGraphicSettings()["LeftGraphic"]; } }
        public string RightGraphic { get { return this.LayoutSettings.GetGraphicSettings()["RightGraphic"]; } }

        public string LeftCroppedGraphic { get { return this.LayoutSettings.GetGraphicSettings()["LeftCroppedGraphic"]; } }
        public string RightCroppedGraphic { get { return this.LayoutSettings.GetGraphicSettings()["RightCroppedGraphic"]; } }

        public string BorderType { get { return this.LayoutSettings.GetGraphicSettings()["BorderType"]; } }

        public string PokeBallGraphic    { get { return this.LayoutSettings.GetGraphicSettings()["PokeballGraphic"]; } }
        public string CurrentPokemonOne  { get { return this.LayoutSettings.GetHuntSettings()["Pokemon-1-AnimatedGif"]; } }
        public string CurrentPokemonTwo  { get { return this.LayoutSettings.GetHuntSettings()["Pokemon-2-AnimatedGif"]; } }



        // Getters for Heights and Widths
        // Entire Display Heights and Widths
        public double ScreenHeight { get { return Convert.ToDouble(this.LayoutSettings.GetOverlaySettings()["ScreenHeight"]);} }
        public double ScreenWidth  { get { return Convert.ToDouble(this.LayoutSettings.GetOverlaySettings()["ScreenWidth"]);} }

        // Normal Graphic Heights and Widths
        public double GraphicHeight { get { return this.LayoutSettings.GetSizeSettings()["GraphicHeight"]; } }
        public double GraphicWidth { get { return this.LayoutSettings.GetSizeSettings()["GraphicWidth"]; } }

        // Cropped Background Graphic Heights and Widths
        public double CroppedBackgroundGraphicHeight { get { return this.LayoutSettings.GetSizeSettings()["CroppedBackgroundGraphicHeight"]; } }
        public double CroppedBackgroundGraphicWidth { get { return this.LayoutSettings.GetSizeSettings()["CroppedBackgroundGraphicWidth"]; } }

        // PokeBall Graphic Heights and Widths
        public double PokeballGraphicHeight { get { return this.LayoutSettings.GetSizeSettings()["PokeballGraphicHeight"]; } }
        public double PokeballGraphicWidth { get { return this.LayoutSettings.GetSizeSettings()["PokeballGraphicWidth"]; } }

        // Text Counter Graphic Heights and Widths
        public double TextCounterHeight { get { return this.LayoutSettings.GetSizeSettings()["TextCounterHeight"]; } }
        public double TextCounterWidth { get { return this.LayoutSettings.GetSizeSettings()["TextCounterWidth"]; } }
        
        // Border Heights and Widths
        public double VerticalBorderHeight   { get { return this.LayoutSettings.GetSizeSettings()["VerticalBorderHeight"];} }
        public double VerticalBorderWidth    { get { return this.LayoutSettings.GetSizeSettings()["VerticalBorderWidth"];} }
        public double HorizontalBorderHeightTop { get { return this.LayoutSettings.GetSizeSettings()["HorizontalBorderHeightTop"];} }
        public double HorizontalBorderHeightBottom { get { return this.LayoutSettings.GetSizeSettings()["HorizontalBorderHeightBottom"]; } }
        public double HorizontalBorderWidth  { get { return this.LayoutSettings.GetSizeSettings()["HorizontalBorderWidth"];} }

        // Size for Animated Gifs
        public double PokemonOneHeight { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-1-Height"]); } }
        public double PokemonOneWidth { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-1-Width"]); } }
        public double PokemonTwoHeight { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-2-Height"]); } }
        public double PokemonTwoWidth { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-1-Width"]); } }




        // Getters for Positioning
        // Positioning for Screen One
        public double ScreenOne_LeftVerticalBorder_PositionX  { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_LeftVerticalBorder_PositionX"]; } }
        public double ScreenOne_LeftVerticalBorder_PositionY  { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_LeftVerticalBorder_PositionY"]; } }

        public double ScreenOne_RightVerticalBorder_PositionX { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_RightVerticalBorder_PositionX"]; } }
        public double ScreenOne_RightVerticalBorder_PositionY { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_RightVerticalBorder_PositionY"]; } }

        public double ScreenOne_UpperHorizontalBorder_PositionX  { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_UpperHorizontalBorder_PositionX"]; } }
        public double ScreenOne_UppertHorizontalBorder_PositionY { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_UppertHorizontalBorder_PositionY"]; } }

        public double ScreenOne_LowerHorizontalBorder_PositionX { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_LowerHorizontalBorder_PositionX"]; } }
        public double ScreenOne_LowerHorizontalBorder_PositionY { get { return this.LayoutSettings.GetPositionSettings()["ScreenOne_LowerHorizontalBorder_PositionY"]; } }

        // Positioning for Screen Two
        public double ScreenTwo_LeftVerticalBorder_PositionX { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_LeftVerticalBorder_PositionX"]; } }
        public double ScreenTwo_LeftVerticalBorder_PositionY { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_LeftVerticalBorder_PositionY"]; } }

        public double ScreenTwo_RightVerticalBorder_PositionX { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_RightVerticalBorder_PositionX"]; } }
        public double ScreenTwo_RightVerticalBorder_PositionY { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_RightVerticalBorder_PositionY"]; } }

        public double ScreenTwo_UpperHorizontalBorder_PositionX  { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_UpperHorizontalBorder_PositionX"]; } }
        public double ScreenTwo_UppertHorizontalBorder_PositionY { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_UppertHorizontalBorder_PositionY"]; } }

        public double ScreenTwo_LowerHorizontalBorder_PositionX { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_LowerHorizontalBorder_PositionX"]; } }
        public double ScreenTwo_LowerHorizontalBorder_PositionY { get { return this.LayoutSettings.GetPositionSettings()["ScreenTwo_LowerHorizontalBorder_PositionY"]; } }

        // PokeBall Graphic Positioning
        public double PokeBallGraphicLeft_PositionX { get { return this.LayoutSettings.GetPositionSettings()["PokeBallGraphicLeft_PositionX"]; } }
        public double PokeBallGraphicLeft_PositionY { get { return this.LayoutSettings.GetPositionSettings()["PokeBallGraphicLeft_PositionY"]; } }
        public double PokeBallGraphicRight_PositionX { get { return this.LayoutSettings.GetPositionSettings()["PokeBallGraphicRight_PositionX"]; } }
        public double PokeBallGraphicRight_PositionY { get { return this.LayoutSettings.GetPositionSettings()["PokeBallGraphicRight_PositionY"]; } }

        // Text Counter Positioning 
        public double TextCounterLeft_PositionX { get { return this.LayoutSettings.GetPositionSettings()["TextCounterLeft_PositionX"]; } }
        public double TextCounterLeft_PositionY { get { return this.LayoutSettings.GetPositionSettings()["TextCounterLeft_PositionY"]; } }
        public double TextCounterRight_PositionX { get { return this.LayoutSettings.GetPositionSettings()["TextCounterRight_PositionX"]; } }
        public double TextCounterRight_PositionY { get { return this.LayoutSettings.GetPositionSettings()["TextCounterRight_PositionY"]; } }


        // Positioning for Left and Right Graphics
        public double GraphicOne_PositionX { get { return this.LayoutSettings.GetPositionSettings()["GraphicOne_PositionX"]; } }
        public double GraphicOne_PositionY { get { return this.LayoutSettings.GetPositionSettings()["GraphicOne_PositionY"]; } }
        public double GraphicTwo_PositionX { get { return this.LayoutSettings.GetPositionSettings()["GraphicTwo_PositionX"]; } }
        public double GraphicTwo_PositionY { get { return this.LayoutSettings.GetPositionSettings()["GraphicTwo_PositionY"]; } }

        // Positions for Animated Gifs
        public double Pokemon_1_PositionX { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-1-PosX"]); } }
        public double Pokemon_1_PositionY { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-1-PosY"]); } }
        public double Pokemon_2_PositionX { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-2-PosX"]); } }
        public double Pokemon_2_PositionY { get { return Convert.ToDouble(this.LayoutSettings.GetHuntSettings()["Pokemon-2-PosY"]); } }


        public double CroppedGraphicSideLeft_Position_X { get { return this.LayoutSettings.GetPositionSettings()["CroppedGraphicSideLeft_Position_X"]; } }
        public double CroppedGraphicMiddleLeft_Position_X { get { return this.LayoutSettings.GetPositionSettings()["CroppedGraphicMiddleLeft_Position_X"]; } }
        public double CroppedGraphicMiddleRight_Position_X { get { return this.LayoutSettings.GetPositionSettings()["CroppedGraphicMiddleRight_Position_X"]; } }
        public double CroppedGraphicSideRight_Position_X { get { return this.LayoutSettings.GetPositionSettings()["CroppedGraphicSideRight_Position_X"]; } }


        // Overalay Settings Settings
        public int CurrentCountOne { get { return Convert.ToInt32(this.LayoutSettings.GetHuntSettings()["HuntOneCount"]); } }
        public int CurrentCountTwo { get { return Convert.ToInt32(this.LayoutSettings.GetHuntSettings()["HuntTwoCount"]); } }

        public string FontType { get { return this.LayoutSettings.GetOverlaySettings()["FontType"]; } }
        public int FontSize { get { return Convert.ToInt32(this.LayoutSettings.GetOverlaySettings()["FontSize"]); } }


        // Other Settings 
        public string CroppedGraphicSide { get { return 0.ToString() + " " + 0.ToString() + " " + this.CroppedBackgroundGraphicWidth.ToString() + " " + this.CroppedBackgroundGraphicHeight.ToString().ToString(); } }
        public string CroppedGraphicMiddle { get { return (0.ToString() + " " + 0.ToString() + " " + (ScreenWidth * 0.015625).ToString() + " " + this.CroppedBackgroundGraphicHeight.ToString()); } }


        // Code that allows the Window to be draggable
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //Below is the boilerplate code supporting PropertyChanged events:
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += HandleKeyPress;
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        { 
            if (e.Key == Key.W)
            {
                currentCount.Content = Convert.ToInt32(currentCount.Content) + 1;
            }

            if (e.Key == Key.S)
            {
                currentCount.Content = Convert.ToInt32(currentCount.Content) - 1;
            }

            if (e.Key == Key.Up)
            {
                currentCount2.Content = Convert.ToInt32(currentCount2.Content) + 1;
            }

            if (e.Key == Key.Down)
            {
                currentCount2.Content = Convert.ToInt32(currentCount2.Content) - 1;
            }

            if (e.Key == Key.Pause)
            {
                Application.Current.Shutdown();
            }
        }

    }
}
