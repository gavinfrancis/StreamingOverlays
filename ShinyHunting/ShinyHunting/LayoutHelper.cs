using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShinyHunting
{
    class LayoutHelper
    {
        private Dictionary<string, string> HuntSettings = new Dictionary<string, string>();
        private Dictionary<string, string> OverlaySettings = new Dictionary<string, string>();
        private Dictionary<string, string> GraphicSettings = new Dictionary<string, string>();
        private Dictionary<string, double> PositionSettings = new Dictionary<string, double>();
        private Dictionary<string, double> SizeSettings = new Dictionary<string, double>();

        private double ScreenWidth;
        private double ScreenHeight;

        // Constructor
        public LayoutHelper()
        {
            this.ReadLaunchSettings();

            this.ScreenHeight = Convert.ToDouble(this.OverlaySettings["ScreenHeight"]);
            this.ScreenWidth = Convert.ToDouble(this.OverlaySettings["ScreenWidth"]);

            this.AssignSizeSettings();
            this.AssignPositionSettings();
        }

        // Switch to dictionary at some point
        public void ReadLaunchSettings()
        {
            // Read entire text file content in one string  


            // For Development Mode
            // string huntSettingsPath = "../../../HuntSettings.txt";
            // string graphicSettingsPath = "../../../GraphicSettings.txt";
            // string overlaySettingsPath = "../../../OverlaySettings.txt";

            // For Executable Mode
            string huntSettingsPath = "Settings/HuntSettings.txt";
            string graphicSettingsPath = "Settings/GraphicSettings.txt";
            string overlaySettingsPath = "Settings/OverlaySettings.txt";

            this.HuntSettings = File.ReadAllLines(huntSettingsPath).Select(x => x.Split(" = ")).ToDictionary(x => x[0], x => x[1]);
            this.GraphicSettings = File.ReadAllLines(graphicSettingsPath).Select(x => x.Split(" = ")).ToDictionary(x => x[0], x => x[1]);
            this.OverlaySettings = File.ReadAllLines(overlaySettingsPath).Select(x => x.Split(" = ")).ToDictionary(x => x[0], x => x[1]);
        }



        public void AssignPositionSettings()
        {
            // Border Positioning based on X/ Y Coordinates for Screen Borders
            // Screen One = Left Screen
            // Screen Two = Right Screen
            double ScreenOne_LeftVerticalBorder_PositionX = this.ScreenWidth * 0.0182291667;
            double ScreenOne_LeftVerticalBorder_PositionY = 0;
            double ScreenOne_RightVerticalBorder_PositionX = this.ScreenWidth * 0.4765625;
            double ScreenOne_RightVerticalBorder_PositionY = 0;

            double ScreenOne_UpperHorizontalBorder_PositionX = this.ScreenWidth * 0.0182291667;
            double ScreenOne_UpperHorizontalBorder_PositionY = 0;
            double ScreenOne_LowerHorizontalBorder_PositionX = this.ScreenWidth * 0.0182291667;
            double ScreenOne_LowerHorizontalBorder_PositionY = this.GetSizeSettings()["VerticalBorderHeight"];

            // Screen Two
            double ScreenTwo_LeftVerticalBorder_PositionX = (this.ScreenWidth * 0.5234375) - this.GetSizeSettings()["VerticalBorderWidth"];
            double ScreenTwo_LeftVerticalBorder_PositionY = 0;
            double ScreenTwo_RightVerticalBorder_PositionX = (this.ScreenWidth * 0.981770833) - this.GetSizeSettings()["VerticalBorderWidth"]; ;
            double ScreenTwo_RightVerticalBorder_PositionY = 0;

            double ScreenTwo_UpperHorizontalBorder_PositionX = (this.ScreenWidth * 0.5234375) - this.GetSizeSettings()["VerticalBorderWidth"]; ;
            double ScreenTwo_UppertHorizontalBorder_PositionY = 0;
            double ScreenTwo_LowerHorizontalBorder_PositionX = (this.ScreenWidth * 0.5234375) - this.GetSizeSettings()["VerticalBorderWidth"]; ;
            double ScreenTwo_LowerHorizontalBorder_PositionY = this.GetSizeSettings()["VerticalBorderHeight"];

            this.PositionSettings.Add("ScreenOne_LeftVerticalBorder_PositionX", ScreenOne_LeftVerticalBorder_PositionX);
            this.PositionSettings.Add("ScreenOne_LeftVerticalBorder_PositionY", ScreenOne_LeftVerticalBorder_PositionY);
            this.PositionSettings.Add("ScreenOne_RightVerticalBorder_PositionX", ScreenOne_RightVerticalBorder_PositionX);
            this.PositionSettings.Add("ScreenOne_RightVerticalBorder_PositionY", ScreenOne_RightVerticalBorder_PositionY);

            this.PositionSettings.Add("ScreenOne_UpperHorizontalBorder_PositionX", ScreenOne_UpperHorizontalBorder_PositionX);
            this.PositionSettings.Add("ScreenOne_UpperHorizontalBorder_PositionY", ScreenOne_UpperHorizontalBorder_PositionY);
            this.PositionSettings.Add("ScreenOne_LowerHorizontalBorder_PositionX", ScreenOne_LowerHorizontalBorder_PositionX);
            this.PositionSettings.Add("ScreenOne_LowerHorizontalBorder_PositionY", ScreenOne_LowerHorizontalBorder_PositionY);

            this.PositionSettings.Add("ScreenTwo_LeftVerticalBorder_PositionX", ScreenTwo_LeftVerticalBorder_PositionX);
            this.PositionSettings.Add("ScreenTwo_LeftVerticalBorder_PositionY", ScreenTwo_LeftVerticalBorder_PositionY);
            this.PositionSettings.Add("ScreenTwo_RightVerticalBorder_PositionX", ScreenTwo_RightVerticalBorder_PositionX);
            this.PositionSettings.Add("ScreenTwo_RightVerticalBorder_PositionY", ScreenTwo_RightVerticalBorder_PositionY);

            this.PositionSettings.Add("ScreenTwo_UpperHorizontalBorder_PositionX", ScreenTwo_UpperHorizontalBorder_PositionX);
            this.PositionSettings.Add("ScreenTwo_UppertHorizontalBorder_PositionY", ScreenTwo_UppertHorizontalBorder_PositionY);
            this.PositionSettings.Add("ScreenTwo_LowerHorizontalBorder_PositionX", ScreenTwo_LowerHorizontalBorder_PositionX);
            this.PositionSettings.Add("ScreenTwo_LowerHorizontalBorder_PositionY", ScreenTwo_LowerHorizontalBorder_PositionY);


            double PokeBallGraphicLeft_PositionX = this.ScreenWidth * 0.2864583333333333;
            double PokeBallGraphicLeft_PositionY = this.ScreenHeight * 0.6481481481481481;
            double PokeBallGraphicRight_PositionX = this.ScreenWidth * 0.7135416666666667;
            double PokeBallGraphicRight_PositionY = this.ScreenHeight * 0.6481481481481481;

            this.PositionSettings.Add("PokeBallGraphicLeft_PositionX", PokeBallGraphicLeft_PositionX);
            this.PositionSettings.Add("PokeBallGraphicLeft_PositionY", PokeBallGraphicLeft_PositionY);
            this.PositionSettings.Add("PokeBallGraphicRight_PositionX", PokeBallGraphicRight_PositionX);
            this.PositionSettings.Add("PokeBallGraphicRight_PositionY", PokeBallGraphicRight_PositionY);


            double TextCounterLeft_PositionX = this.ScreenWidth * 0.09375;
            double TextCounterLeft_PositionY = this.ScreenHeight * 0.7075;
            double TextCounterRight_PositionX = this.ScreenWidth * 0.8046875;
            double TextCounterRight_PositionY = this.ScreenHeight * 0.7075;

            this.PositionSettings.Add("TextCounterLeft_PositionX", TextCounterLeft_PositionX);
            this.PositionSettings.Add("TextCounterLeft_PositionY", TextCounterLeft_PositionY);
            this.PositionSettings.Add("TextCounterRight_PositionX", TextCounterRight_PositionX);
            this.PositionSettings.Add("TextCounterRight_PositionY", TextCounterRight_PositionY);


            double GraphicOne_PositionX = 0;
            double GraphicOne_PositionY = this.GetSizeSettings()["VerticalBorderHeight"] + this.GetSizeSettings()["HorizontalBorderHeightBottom"];
            double GraphicTwo_PositionX = this.ScreenWidth / 2;
            double GraphicTwo_PositionY = this.GetSizeSettings()["VerticalBorderHeight"] + this.GetSizeSettings()["HorizontalBorderHeightBottom"];

            this.PositionSettings.Add("GraphicOne_PositionX", GraphicOne_PositionX);
            this.PositionSettings.Add("GraphicOne_PositionY", GraphicOne_PositionY);
            this.PositionSettings.Add("GraphicTwo_PositionX", GraphicTwo_PositionX);
            this.PositionSettings.Add("GraphicTwo_PositionY", GraphicTwo_PositionY);

            double CroppedGraphicSideLeft_Position_X = 0;
            double CroppedGraphicMiddleLeft_Position_X = this.ScreenWidth * 0.484375;
            double CroppedGraphicMiddleRight_Position_X = this.ScreenWidth * 0.5;
            double CroppedGraphicSideRight_Position_X = this.ScreenWidth * 0.9817708333333333;

            this.PositionSettings.Add("CroppedGraphicSideLeft_Position_X", CroppedGraphicSideLeft_Position_X);
            this.PositionSettings.Add("CroppedGraphicMiddleLeft_Position_X", CroppedGraphicMiddleLeft_Position_X);
            this.PositionSettings.Add("CroppedGraphicMiddleRight_Position_X", CroppedGraphicMiddleRight_Position_X);
            this.PositionSettings.Add("CroppedGraphicSideRight_Position_X", CroppedGraphicSideRight_Position_X);

        }


        public void AssignSizeSettings()
        {
            // Size Settings for Screen Borders
            double verticalBorderHeight = this.ScreenHeight * 0.6296296;
            double verticalBorderWidth = this.ScreenWidth * 0.0078125;
            double horizontalBorderHeightTop = 32.5;
            double horizontalBorderHeightBottom = this.ScreenHeight * 0.0138888888888889;
            double horizontalBorderWidth = (this.ScreenWidth * 0.45833) + horizontalBorderHeightBottom;

            this.SizeSettings.Add("VerticalBorderHeight", verticalBorderHeight);
            this.SizeSettings.Add("VerticalBorderWidth", verticalBorderWidth);
            this.SizeSettings.Add("HorizontalBorderHeightTop", horizontalBorderHeightTop);
            this.SizeSettings.Add("HorizontalBorderHeightBottom", horizontalBorderHeightBottom);
            this.SizeSettings.Add("HorizontalBorderWidth", horizontalBorderWidth);

            // Master Size and Positioning for Cropped Backgrounds
            double croppedBackgroundGraphicHeight = this.ScreenHeight * 0.6535185185185185;
            double croppedBackgroundGraphicWidth = this.ScreenWidth * 0.0182291666666667;

            this.SizeSettings.Add("CroppedBackgroundGraphicHeight", croppedBackgroundGraphicHeight);
            this.SizeSettings.Add("CroppedBackgroundGraphicWidth", croppedBackgroundGraphicWidth);


            double GraphicHeight = this.ScreenHeight / 2;
            double GraphicWidth = this.ScreenWidth / 2;
            this.SizeSettings.Add("GraphicHeight", GraphicHeight);
            this.SizeSettings.Add("GraphicWidth", GraphicWidth);


            double PokeballGraphicHeight = this.ScreenWidth * 0.1953125;
            double PokeballGraphicWidth = this.ScreenWidth * 0.1953125;
            this.SizeSettings.Add("PokeballGraphicHeight", PokeballGraphicHeight);
            this.SizeSettings.Add("PokeballGraphicWidth", PokeballGraphicWidth);


            double TextCounterHeight = this.ScreenWidth * 0.062962962962963;
            double TextCounterWidth = this.ScreenWidth * 0.1177083333333333;
            this.SizeSettings.Add("TextCounterHeight", TextCounterHeight);
            this.SizeSettings.Add("TextCounterWidth", TextCounterWidth);
        }

    public Dictionary<string, string> GetHuntSettings()
        {
            return this.HuntSettings;
        }

        public Dictionary<string, string> GetOverlaySettings()
        {
            return this.OverlaySettings;
        }

        public Dictionary<string, string> GetGraphicSettings()
        {
            return this.GraphicSettings;
        }

        public Dictionary<string, double> GetSizeSettings()
        {
            return this.SizeSettings;
        }

        public Dictionary<string, double> GetPositionSettings()
        {
            return this.PositionSettings;
        }


    }
}
