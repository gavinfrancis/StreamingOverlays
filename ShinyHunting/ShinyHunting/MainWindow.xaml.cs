using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        // Border Positioning based on X/Y Coordinates
        // Screen One = Left Screen
        // Screen Two = Right Screen

        // Positioning for Screen One
        public double ScreenOne_LeftVerticalBorder_PositionX  { get { return Convert.ToDouble(0);} }
        public double ScreenOne_LeftVerticalBorder_PositionY { get { return Convert.ToDouble(0); } }

        public double ScreenOne_RightVerticalBorder_PositionX { get { return (this.ScreenWidth / 2) - 10;} }
        public double ScreenOne_RightVerticalBorder_PositionY { get { return Convert.ToDouble(0); } }

        public double ScreenOne_UpperHorizontalBorder_PositionX { get { return Convert.ToDouble(0); } }
        public double ScreenOne_UppertHorizontalBorder_PositionY { get { return Convert.ToDouble(0); } }

        public double ScreenOne_LowerHorizontalBorder_PositionX { get { return (0); } }
        public double ScreenOne_LowerHorizontalBorder_PositionY { get { return this.VerticalBorderHeight; } }

        // Positioning for Screen Two
        public double ScreenTwo_LeftVerticalBorder_PositionX { get { return (this.ScreenWidth / 2) + 10;} }
        public double ScreenTwo_LeftVerticalBorder_PositionY { get { return Convert.ToDouble(0);} }

        public double ScreenTwo_RightVerticalBorder_PositionX { get { return this.ScreenWidth;} }
        public double ScreenTwo_RightVerticalBorder_PositionY { get { return Convert.ToDouble(0);} }

        public double ScreenTwo_UpperHorizontalBorder_PositionX { get { return (this.ScreenWidth / 2) + 10;} }
        public double ScreenTwo_UppertHorizontalBorder_PositionY { get { return Convert.ToDouble(0);} }

        public double ScreenTwo_LowerHorizontalBorder_PositionX { get { return (this.ScreenWidth / 2) + 10; } }
        public double ScreenTwo_LowerHorizontalBorder_PositionY { get { return this.VerticalBorderHeight;} }


        // Accessing Graphics Paths
        public string BorderType { get { return this.LayoutSettings.GetGraphicSettings()["BorderType"];} }



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
    }
}
