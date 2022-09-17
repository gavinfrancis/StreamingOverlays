using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        // Getters that are accessed within the Main Display Window   //
        // ********************************************************** //

        // Entire Display Heights and Widths
        public double ScreenHeight { get { return Convert.ToDouble(this.LayoutSettings.GetLaunchSettings()["ScreenHeight"]);} }
        public double ScreenWidth  { get { return Convert.ToDouble(this.LayoutSettings.GetLaunchSettings()["ScreenWidth"]);} }

        // Border Heights and Widths
        public double VerticalBorderHeight   { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["VerticalBorderHeight"]);} }
        public double VerticalBorderWidth    { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["VerticalBorderWidth"]);} }
        public double HorizontalBorderHeight { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["HorizontalBorderHeight"]);} }
        public double HorizontalBorderWidth  { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["HorizontalBorderWidth"]);} }

        public double CroppedBackgroundGraphicHeight { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["CroppedBackgroundGraphicHeight"]); } }
        public double CroppedBackgroundGraphicWidth { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["CroppedBackgroundGraphicWidth"]); } }

        // Graphic Heights and Widths
        public double GraphicHeight { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["GraphicHeight"]); } }
        public double GraphicWidth { get { return Convert.ToDouble(this.LayoutSettings.GetDoubleHuntSettings()["GraphicWidth"]); } }

        // Border Positioning based on X/Y Coordinates
        // Screen One = Left Screen
        // Screen Two = Right Screen

        // Positioning for Screen One
        public double ScreenOne_LeftVerticalBorder_PositionX  { get { return Convert.ToDouble(this.ScreenWidth * 0.0182291667);} }
        public double ScreenOne_LeftVerticalBorder_PositionY { get { return Convert.ToDouble(0); } }

        public double ScreenOne_RightVerticalBorder_PositionX { get { return Convert.ToDouble(this.ScreenWidth * 0.4765625); } }
        public double ScreenOne_RightVerticalBorder_PositionY { get { return Convert.ToDouble(0); } }

        public double ScreenOne_UpperHorizontalBorder_PositionX { get { return Convert.ToDouble(this.ScreenWidth * 0.0182291667); } }
        public double ScreenOne_UppertHorizontalBorder_PositionY { get { return Convert.ToDouble(0); } }

        public double ScreenOne_LowerHorizontalBorder_PositionX { get { return Convert.ToDouble(this.ScreenWidth * 0.0182291667); } }
        public double ScreenOne_LowerHorizontalBorder_PositionY { get { return this.VerticalBorderHeight; } }

        // Positioning for Screen Two
        public double ScreenTwo_LeftVerticalBorder_PositionX { get { return Convert.ToDouble(this.ScreenWidth * 0.5234375) - this.VerticalBorderWidth; } }
        public double ScreenTwo_LeftVerticalBorder_PositionY { get { return Convert.ToDouble(0);} }

        public double ScreenTwo_RightVerticalBorder_PositionX { get { return Convert.ToDouble(this.ScreenWidth * 0.981770833) - this.VerticalBorderWidth; } }
        public double ScreenTwo_RightVerticalBorder_PositionY { get { return Convert.ToDouble(0);} }

        public double ScreenTwo_UpperHorizontalBorder_PositionX { get { return Convert.ToDouble(this.ScreenWidth * 0.5234375) - this.VerticalBorderWidth; } }
        public double ScreenTwo_UppertHorizontalBorder_PositionY { get { return Convert.ToDouble(0);} }

        public double ScreenTwo_LowerHorizontalBorder_PositionX { get { return Convert.ToDouble(this.ScreenWidth * 0.5234375) - this.VerticalBorderWidth; } }
        public double ScreenTwo_LowerHorizontalBorder_PositionY { get { return this.VerticalBorderHeight;} }

        // Positioning for Left and Right Graphics
        public double GraphicOne_PositionX { get { return 0; } }
        public double GraphicOne_PositionY { get { return this.VerticalBorderHeight + this.HorizontalBorderHeight; } }

        public double GraphicTwo_PositionX { get { return (this.ScreenWidth / 2); } }
        public double GraphicTwo_PositionY { get { return this.VerticalBorderHeight + this.HorizontalBorderHeight; } }


        public double CroppedGraphicSideLeft_Position_X { get { return Convert.ToDouble(0); } }
        public double CroppedGraphicMiddleLeft_Position_X { get { return Convert.ToDouble(this.ScreenWidth * 0.484375); } }
        public double CroppedGraphicMiddleRight_Position_X { get { return Convert.ToDouble(this.ScreenWidth * 0.5); } }
        public double CroppedGraphicSideRight_Position_X { get { return Convert.ToDouble(this.ScreenWidth * 0.9817708333333333); } }

        // Edit Later
        public string CroppedGraphicSide{ get { return (0.ToString() + " " + 0.ToString() + " " + this.CroppedBackgroundGraphicWidth.ToString() + " " + this.CroppedBackgroundGraphicHeight.ToString()); } }
        public string CroppedGraphicMiddle { get { return (0.ToString() + " " + 0.ToString() + " " + (30).ToString() + " " + this.CroppedBackgroundGraphicHeight.ToString()); } }


        // Accessing Graphics Paths
        public string LeftGraphic { get { return this.LayoutSettings.GetGraphicSettings()["LeftGraphic"]; } }
        public string RightGraphic { get { return this.LayoutSettings.GetGraphicSettings()["RightGraphic"]; } }
        public string LeftCroppedGraphic { get { return this.LayoutSettings.GetGraphicSettings()["LeftCroppedGraphic"]; } }
        public string RightCroppedGraphic { get { return this.LayoutSettings.GetGraphicSettings()["RightCroppedGraphic"]; } }

        public string PokeBallGraphic { get { return this.LayoutSettings.GetGraphicSettings()["PokeballGraphic"]; } }

        public string TestGraphic { get { return this.LayoutSettings.GetGraphicSettings()["TestGraphic"]; } }
        public string BorderType { get { return this.LayoutSettings.GetGraphicSettings()["BorderType"];} }

        


        // Code that allows the Window to be draggable
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                currentCount.Content = 1000;
                Debug.WriteLine("Hi");
            }
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
    }
}
