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

        }

        public void AssignGraphicSettings()
        {
            this.GraphicSettings.Add("BorderType", this.LaunchSettings["BorderType"]);
        }

        public void AssignDoubleHuntSettings()
        {
            // Assigns values for screen height and width
            double screenHeight = Convert.ToDouble(this.LaunchSettings["ScreenHeight"]);
            double screenWidth = Convert.ToDouble(this.LaunchSettings["ScreenWidth"]);

            // Assigns values for display borders
            double verticalBorderHeight = screenHeight / 2;
            double verticalBorderWidth = 15 / 1;
            this.DoubleHuntSettings.Add("VerticalBorderHeight", verticalBorderHeight.ToString());
            this.DoubleHuntSettings.Add("VerticalBorderWidth", verticalBorderWidth.ToString());

            double horizontalBorderHeight = 15 / 1;
            double horizontalBorderWidth = screenWidth / 2;
            this.DoubleHuntSettings.Add("HorizontalBorderHeight", horizontalBorderHeight.ToString());
            this.DoubleHuntSettings.Add("HorizontalBorderWidth", horizontalBorderWidth.ToString());
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
