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
        public Point ResetAppPoint { get; set; }
        public Point ResetPoint1 { get; set; }
        public Point ResetPoint2 { get; set; }
        public Point ResetPoint3 { get; set; }       

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
