using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShinyHunting
{
    class LayoutHelper
    {
        private Dictionary<string, string> LaunchSettings = new Dictionary<string, string>();
        private Dictionary<string, string> DoubleHuntSettings = new Dictionary<string, string>();
        private Dictionary<string, string> GraphicSettings = new Dictionary<string, string>();

        private double ScreenWidth;
        private double ScreenHeight;

        // Constructor
        public LayoutHelper()
        {
            this.ReadLaunchFileSettings();

            this.AssignDoubleHuntSettings();
            this.AssignGraphicSettings();
        }

        // Switch to dictionary at some point
        public void ReadLaunchFileSettings()
        {
            // Read entire text file content in one string  
            //string path = Directory.GetCurrentDirectory();
            string path = "../../../LaunchSettings.txt";
            this.LaunchSettings = File.ReadAllLines(path).Select(x => x.Split(" = ")).ToDictionary(x => x[0], x => x[1]);

            this.ScreenHeight = Convert.ToDouble(this.LaunchSettings["ScreenHeight"]);
            this.ScreenWidth = Convert.ToDouble(this.LaunchSettings["ScreenWidth"]);
        }

        public void AssignGraphicSettings()
        {
            this.GraphicSettings.Add("LeftGraphic", this.LaunchSettings["LeftGraphic"]);
            this.GraphicSettings.Add("RightGraphic", this.LaunchSettings["RightGraphic"]);
            this.GraphicSettings.Add("LeftCroppedGraphic", this.LaunchSettings["LeftCroppedGraphic"]);
            this.GraphicSettings.Add("RightCroppedGraphic", this.LaunchSettings["RightCroppedGraphic"]);
            this.GraphicSettings.Add("PokeballGraphic", this.LaunchSettings["PokeballGraphic"]);
            
            this.GraphicSettings.Add("TestGraphic", this.LaunchSettings["TestGraphic"]);

            this.GraphicSettings.Add("BorderType", this.LaunchSettings["BorderType"]);

            // Assigns values for display borders
            double GraphicHeight = this.ScreenHeight / 2;
            double GraphicWidth = this.ScreenWidth / 2;
            this.DoubleHuntSettings.Add("GraphicHeight", GraphicHeight.ToString());
            this.DoubleHuntSettings.Add("GraphicWidth", GraphicWidth.ToString());

        }

        public void AssignDoubleHuntSettings()
        {

            // Assigns values for display borders
            double verticalBorderHeight = this.ScreenHeight * 0.6296296;
            double verticalBorderWidth = 15 / 1;
            this.DoubleHuntSettings.Add("VerticalBorderHeight", verticalBorderHeight.ToString());
            this.DoubleHuntSettings.Add("VerticalBorderWidth", verticalBorderWidth.ToString());

            double horizontalBorderHeight = 15 / 1;
            double horizontalBorderWidth = (this.ScreenWidth * 0.45833) + horizontalBorderHeight;
            this.DoubleHuntSettings.Add("HorizontalBorderHeight", horizontalBorderHeight.ToString());
            this.DoubleHuntSettings.Add("HorizontalBorderWidth", horizontalBorderWidth.ToString());

            double croppedBackgroundGraphicHeight = this.ScreenHeight * 0.6535185185185185;
            double croppedBackgroundGraphicWidth = this.ScreenWidth * 0.0182291666666667;

            this.DoubleHuntSettings.Add("CroppedBackgroundGraphicHeight", croppedBackgroundGraphicHeight.ToString());
            this.DoubleHuntSettings.Add("CroppedBackgroundGraphicWidth", croppedBackgroundGraphicWidth.ToString());
        }

        public Dictionary<string, string> GetGraphicSettings()
        {
            return this.GraphicSettings;
        }

        public Dictionary<string, string> GetLaunchSettings()
        {
            return this.LaunchSettings;
        }

        public Dictionary<string, string> GetDoubleHuntSettings()
        {
            return this.DoubleHuntSettings;
        }
    }
}
