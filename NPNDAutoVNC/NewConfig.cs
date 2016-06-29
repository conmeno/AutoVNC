using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
namespace NPNDAutoVNC
{
    public class NewConfig
    {

        public int Sleep { get; set; }
        public string VNCName { get; set; }

        public int NumberRoundClickAd { get; set; }
        public Point VNCPoint { get; set; }
        public  Point AppPoint { get; set; }

        public Point AppPoint2 { get; set; }
        public Point AdPoint { get; set; }

        public Point ClosePoint { get; set; }

        public bool autoStart { get; set; }

        public decimal waitTime { get; set; }

        //setting point
        public Point SettingPoint { get; set; } 


        //Privacy app on homescreen
        public Point AdvertisingPoint { get; set; }
        public Point AdvertisingPoint1 { get; set; }
        public Point AdvertisingPoint2 { get; set; }


        public string VNCConfigFile { get; set; }
        public string VNCPasswordCode { get; set; }
        public string DefaultIP { get; set; }

        [XmlIgnore]
        public static NewConfig Config { get; set; }

    }
    public class VNC
    {
        public string IP { get; set; }
        public int Status { get; set; }
        public int Action { get; set; }


        public  VNC()
        { 
        }
        public VNC(string IP, int Status, int Action)
        {
        }
    }
}
