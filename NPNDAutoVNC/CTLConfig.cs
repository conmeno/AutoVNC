using System;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace NPNDAutoVNC
{
    class CTLConfig
    {
        public static string _ProcessName;
        public static string _ControlIDIP;
        public static string _ControlIDPass;
        public static string _PathVNC;
        public static string _Sleep;
        public static string _Time1to24;
        public static  Point _PointAD;
        public static Point _PointAppCl;
        public static Point _pointRightClick;
        public static Point _PointStartApp;
        public static Point _PointFirtApp;

        public static Point _PointAppResetAd;
        public static Point _PointResetAdID1;
        public static Point _PointResetAdID2;
        public static Point _PointResetAdID3;


        public static Point _PointVNCConnect;
        public static Point _PointOK;
        public static int _SLApp;
        public static int _WidthApp;
        public static int _hightApp;
        //public static string _Time12to24;
        
        public static void GetConfiguration()
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(Environment.CurrentDirectory + @"\Config.xml");
                _ProcessName = document.SelectSingleNode("//ProcessName").Attributes["Value"].Value;
                _ControlIDIP = document.SelectSingleNode("//ControlIDIP").Attributes["Value"].Value;
                _ControlIDPass = document.SelectSingleNode("//ControlIDPass").Attributes["Value"].Value;
                _PathVNC = document.SelectSingleNode("//Path").Attributes["Value"].Value;
                _Sleep = document.SelectSingleNode("//Sleep").Attributes["Value"].Value;
                _Time1to24 = document.SelectSingleNode("//Time1to24").Attributes["Value"].Value;
                string strPointAD = document.SelectSingleNode("//PointADAPP").Attributes["Value"].Value;
                string[] strad = strPointAD.Split(',');
                _PointAD = new Point(Convert.ToInt32(strad[0]), Convert.ToInt32(strad[1]));

                string strPointAPPClose = document.SelectSingleNode("//PointAppClo").Attributes["Value"].Value;
                string[] strappclose = strPointAPPClose.Split(',');
                _PointAppCl = new Point(Convert.ToInt32(strappclose[0]), Convert.ToInt32(strappclose[1]));

                string strPointRightClick = document.SelectSingleNode("//PointRightClick").Attributes["Value"].Value;
                string[] strRightClick = strPointRightClick.Split(',');
                _pointRightClick= new Point(Convert.ToInt32(strRightClick[0]), Convert.ToInt32(strRightClick[1]));

                string strPointStartApp = document.SelectSingleNode("//PointStartApp").Attributes["Value"].Value;
                string[] strPontStartapp = strPointStartApp.Split(',');
                _PointStartApp = new Point(Convert.ToInt32(strPointStartApp[0]), Convert.ToInt32(strPontStartapp[1]));

                string strfirtapp = document.SelectSingleNode("//PointFirtApp").Attributes["Value"].Value;
                string[] strPontfirtapp = strfirtapp.Split(',');
                _PointFirtApp = new Point(Convert.ToInt32(strPontfirtapp[0]), Convert.ToInt32(strPontfirtapp[1]));


                //phuong edit
                string strAppResetAd = document.SelectSingleNode("//PointAppResetAd").Attributes["Value"].Value;
                string[] strPontAppResetAd = strAppResetAd.Split(',');
                _PointAppResetAd = new Point(Convert.ToInt32(strPontAppResetAd[0]), Convert.ToInt32(strPontAppResetAd[1]));


                string strResetAdID1 = document.SelectSingleNode("//PointResetAdID1").Attributes["Value"].Value;
                string[] strPontResetAdID1 = strResetAdID1.Split(',');
                _PointResetAdID1 = new Point(Convert.ToInt32(strPontResetAdID1[0]), Convert.ToInt32(strPontResetAdID1[1]));

                string strResetAdID2 = document.SelectSingleNode("//PointResetAdID2").Attributes["Value"].Value;
                string[] strPontResetAdID2 = strResetAdID2.Split(',');
                _PointResetAdID2 = new Point(Convert.ToInt32(strPontResetAdID2[0]), Convert.ToInt32(strPontResetAdID2[1]));


                string strResetAdID3 = document.SelectSingleNode("//PointResetAdID3").Attributes["Value"].Value;
                string[] strPontResetAdID3 = strResetAdID3.Split(',');
                _PointResetAdID3 = new Point(Convert.ToInt32(strPontResetAdID3[0]), Convert.ToInt32(strPontResetAdID3[1]));



                //end phuong edit

                string strvncconnect = document.SelectSingleNode("//PointVNCConnect").Attributes["Value"].Value;
                string[] strPontVNCCon = strvncconnect.Split(',');
                _PointVNCConnect = new Point(Convert.ToInt32(strPontVNCCon[0]), Convert.ToInt32(strPontVNCCon[1]));

                string strVNCOK = document.SelectSingleNode("//PointOK").Attributes["Value"].Value;
                string[] strPontOK = strVNCOK.Split(',');
                _PointOK = new Point(Convert.ToInt32(strPontOK[0]), Convert.ToInt32(strPontOK[1]));

                _SLApp = Convert.ToInt32("0"+ document.SelectSingleNode("//SLApp").Attributes["Value"].Value);
                _WidthApp = Convert.ToInt32("0" + document.SelectSingleNode("//WidthApp").Attributes["Value"].Value);
                _hightApp = Convert.ToInt32("0" + document.SelectSingleNode("//HightApp").Attributes["Value"].Value);
            }
            catch (Exception exception)
            {
                CtlError.WriteError("CTLConfig getconfig", exception.Message);
                return ;
                throw new Exception(exception.Message);
            }
        }
        public static void Setvalue(string Time1to24)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(Environment.CurrentDirectory + @"\Config.xml");
                document.SelectSingleNode("//Time1to24").Attributes["Value"].Value = Time1to24;
                document.Save(Path.Combine(Application.StartupPath, "Config.xml"));
            }
            catch (Exception ex)
            {
                CtlError.WriteError("Loi Setvalue Time1to24", ex.Message);
                return;
            }
        }
        public static void SetSLApp(string slapp)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(Environment.CurrentDirectory + @"\Config.xml");
                document.SelectSingleNode("//SLApp").Attributes["Value"].Value = slapp;
                document.Save(Path.Combine(Application.StartupPath, "Config.xml"));
            }
            catch (Exception ex)
            {
                CtlError.WriteError("Loi Setvalue SLApp", ex.Message);
                return;
            }
        }
        public static void SetWidthApp(string width)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(Environment.CurrentDirectory + @"\Config.xml");
                document.SelectSingleNode("//WidthApp").Attributes["Value"].Value = width;
                document.Save(Path.Combine(Application.StartupPath, "Config.xml"));
            }
            catch (Exception ex)
            {
                CtlError.WriteError("Loi Setvalue width", ex.Message);
                return;
            }
        }
        public static void SetHightApp(string hight)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(Environment.CurrentDirectory + @"\Config.xml");
                document.SelectSingleNode("//HightApp").Attributes["Value"].Value = hight;
                document.Save(Path.Combine(Application.StartupPath, "Config.xml"));
            }
            catch (Exception ex)
            {
                CtlError.WriteError("Loi Setvalue Hight", ex.Message);
                return;
            }
        }
    }
}
