﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
namespace NPNDAutoVNC
{
    class Utility
    {
        #region bien

        private const int WM_CLOSE = 16;
        private const int BN_CLICKED = 245;

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, String lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
        [DllImport("user32.dll")]
        public static extern int GetDlgCtrlID(IntPtr hwnd);
        //mouse
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }



        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoin);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        //
        System.Data.Odbc.OdbcDataAdapter obj_oledb_da;

        #region Bien chuon trinh

        private bool _isGetPoint = false;
        private Queue<Int32> _listQty = new Queue<int>();
        private List<Int32> _listQty24 = new List<int>();
        private Queue<string> _ShowAdCurr = new Queue<string>();
        private bool _isstart = false;
        int _currentHour = 0;
        private bool _isRestartAppOK = true;
        int _countCloseAd = 59;
        bool _isstop = false;
        #endregion

        #endregion
        public static string Serialize(object oObject, bool Indent = false)
        {
            System.Xml.Serialization.XmlSerializer oXmlSerializer = null;
            System.Text.StringBuilder oStringBuilder = null;
            System.Xml.XmlWriter oXmlWriter = null;
            string sXML = null;
            System.Xml.XmlWriterSettings oXmlWriterSettings = null;
            System.Xml.Serialization.XmlSerializerNamespaces oXmlSerializerNamespaces = null;

            // -----------------------------------------------------------------------------------------------------------------------
            // Lage XML
            // -----------------------------------------------------------------------------------------------------------------------
            oStringBuilder = new System.Text.StringBuilder();
            oXmlSerializer = new System.Xml.Serialization.XmlSerializer(oObject.GetType());
            oXmlWriterSettings = new System.Xml.XmlWriterSettings();
            oXmlWriterSettings.OmitXmlDeclaration = true;
            oXmlWriterSettings.Indent = Indent;
            oXmlWriter = System.Xml.XmlWriter.Create(new System.IO.StringWriter(oStringBuilder), oXmlWriterSettings);
            oXmlSerializerNamespaces = new System.Xml.Serialization.XmlSerializerNamespaces();
            oXmlSerializerNamespaces.Add(string.Empty, string.Empty);
            oXmlSerializer.Serialize(oXmlWriter, oObject, oXmlSerializerNamespaces);
            oXmlWriter.Close();
            sXML = oStringBuilder.ToString();

            return sXML;
        }

        public static object DeSerialize(string sXML, Type ObjectType)
        {
            System.IO.StringReader oStringReader = null;
            System.Xml.Serialization.XmlSerializer oXmlSerializer = null;
            object oObject = null;

            // -----------------------------------------------------------------------------------------------------------------------
            // Hvis mangler info, lage tom
            // -----------------------------------------------------------------------------------------------------------------------
            if (sXML == string.Empty)
            {
                Type[] types = new Type[-1 + 1];
                System.Reflection.ConstructorInfo info = ObjectType.GetConstructor(types);
                object targetObject = info.Invoke(null);
                if (targetObject == null)
                    return null;
                return targetObject;
            }

            // -----------------------------------------------------------------------------------------------------------------------
            // Gjøre om fra XML til objekt
            // -----------------------------------------------------------------------------------------------------------------------
            oStringReader = new System.IO.StringReader(sXML);
            oXmlSerializer = new System.Xml.Serialization.XmlSerializer(ObjectType);
            oObject = oXmlSerializer.Deserialize(oStringReader);

            return oObject;
        }


        public static void OpenVNCFile(string ip)
        {
            string VNCPath = Application.StartupPath + "\\VNC\\" + ip + ".vnc";
            Process.Start(VNCPath);

        }


        //phuong edit
        public static void OpenApps(BindingList<VNC> VNCList, bool isResetAd, bool clickAd)
        {
            foreach (var item in VNCList)
            {
                if (item.IP != null)
                    if (item.IP.Trim() != string.Empty)
                    {
                        OpenVNCFile(NewConfig.Config.DefaultIP + item.IP);
                        Thread.Sleep(1000);
                        //Point app = GetPointRandonApp(Convert.ToInt32("0" + txtslapp.Text));

                        if (clickAd)
                        {
                            ClickAd(NewConfig.Config.AdPoint);
                        }
                        else
                        {
                            if (isResetAd)
                            {
                                ResetAd(NewConfig.Config.ResetAppPoint, NewConfig.Config.ResetPoint1, NewConfig.Config.ResetPoint2, NewConfig.Config.ResetPoint3);
                            }

                            CloseAndRestart(NewConfig.Config.AppPoint, NewConfig.Config.ClosePoint);
                        }

                        


                        Thread.Sleep(1000);
                        Process p = Process.GetProcessesByName(CTLConfig._ProcessName)[0];
                        if (p != null)
                            p.Kill();
                    }
            }

        }


        public static void ListIPtoFiles(BindingList<VNC> VNCList)
        {
            string VNCPath = Application.StartupPath + "\\VNC";
            DirectoryInfo VNC = new DirectoryInfo(VNCPath);
            if (!Directory.Exists(VNCPath))
                Directory.CreateDirectory(VNCPath);
            string VNCConfigTextFile = Application.StartupPath + "\\VNCConfigFile.txt";
            string VNCConfigText = "";
            if (File.Exists(VNCConfigTextFile))
            {
                VNCConfigText = File.ReadAllText(VNCConfigTextFile);
            }
            foreach (var item in VNCList)
            {
                string fileName = VNCPath + "\\" + NewConfig.Config.DefaultIP + item.IP + ".vnc";
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine("[Connection]");
                sw.WriteLine("Host=" + NewConfig.Config.DefaultIP + item.IP);
                sw.WriteLine("Password=b4d90014103bde54");
                sw.WriteLine(VNCConfigText);
                sw.Close();
            }

        }

        public static NewConfig LoadConfig(bool vncPoint = true)
        {
            string ConfigPath = Application.StartupPath + "\\newconfig.txt";
            NewConfig Config = new NewConfig();
            try
            {
                Config = (NewConfig)DeSerialize(System.IO.File.ReadAllText(ConfigPath), typeof(NewConfig));

                if (vncPoint)
                {
                    Config.AppPoint = new Point(Config.VNCPoint.X + Config.AppPoint.X, Config.VNCPoint.Y + Config.AppPoint.Y);

                    Config.AppPoint2 = new Point(Config.VNCPoint.X + Config.AppPoint2.X, Config.VNCPoint.Y + Config.AppPoint2.Y);

                    Config.AdPoint = new Point(Config.VNCPoint.X + Config.AdPoint.X, Config.VNCPoint.Y + Config.AdPoint.Y);

                    Config.ClosePoint = new Point(Config.VNCPoint.X + Config.ClosePoint.X, Config.VNCPoint.Y + Config.ClosePoint.Y);

                    Config.ResetAppPoint = new Point(Config.VNCPoint.X + Config.ResetAppPoint.X, Config.VNCPoint.Y + Config.ResetAppPoint.Y);

                    Config.ResetPoint1 = new Point(Config.VNCPoint.X + Config.ResetPoint1.X, Config.VNCPoint.Y + Config.ResetPoint1.Y);

                    Config.ResetPoint2 = new Point(Config.VNCPoint.X + Config.ResetPoint2.X, Config.VNCPoint.Y + Config.ResetPoint2.Y);

                    Config.ResetPoint3 = new Point(Config.VNCPoint.X + Config.ResetPoint3.X, Config.VNCPoint.Y + Config.ResetPoint3.Y);
                }
            }
            catch
            {
                Config = null;
            }

            NewConfig.Config = Config;
            return Config;
        }


        public static void SaveConfig(NewConfig Config)
        {
            string ConfigPath = Application.StartupPath + "\\newconfig.txt";

            //NewConfig Config = new NewConfig();
            //Config.AdPoint = new Point();
            //Config.AppPoint = new Point();
            //Config.DefaultIP = "192.168.1.";
            //Config.ResetAppPoint = new Point();
            //Config.ResetPoint1 = new Point();
            //Config.ResetPoint2 = new Point();
            //Config.ResetPoint3 = new Point();
            //Config.ResetPoint4 = new Point();
            //Config.Sleep = 1000;
            //Config.VNCConfigFile = "main.vnc";
            //Config.VNCPasswordCode = "b4d90014103bde54";
            //Config.VNCPoint = new Point();

            string XML = Serialize(Config, true);
            System.IO.StreamWriter sr = new StreamWriter(ConfigPath);
            sr.WriteLine(XML);
            sr.Close();

        }
        //public static List<VNC> LoadVNCList()
        //{
        //   string VNCListPath = Application.StartupPath + "\\ListVNC.txt";
        //   List<VNC> listVNC = new List<VNC>();
        //   try
        //   {
        //       listVNC = (List<VNC>)DeSerialize(System.IO.File.ReadAllText(VNCListPath), typeof(List<VNC>));
        //   }
        //   catch
        //   { 

        //   }

        //   return listVNC;
        //}
        public static BindingList<VNC> LoadVNCListBind()
        {
            string VNCListPath = Application.StartupPath + "\\ListVNC.txt";
            BindingList<VNC> listVNC = new BindingList<VNC>();
            try
            {
                listVNC = (BindingList<VNC>)DeSerialize(System.IO.File.ReadAllText(VNCListPath), typeof(BindingList<VNC>));
            }
            catch
            {

            }

            return listVNC;
        }
        public static void SaveListVNC(BindingList<VNC> listVNC)
        {
            string VNCListPath = Application.StartupPath + "\\ListVNC.txt";
            if (listVNC.Count == 0)
                listVNC.Add(new VNC());
            string XML = Serialize(listVNC, true);
            System.IO.StreamWriter sr = new StreamWriter(VNCListPath);
            sr.WriteLine(XML);
            sr.Close();
        }

        public static void Startad(Point Pad)
        {
            Thread.Sleep(2000);
            SetCursorPos(Pad.X, Pad.Y);
            Thread.Sleep(500);
            sendMouseLeftclick(Pad);
        }
        public static void CloseAndRestart(Point appstart, Point appclose)
        {
            SetCursorPos(appclose.X, appclose.Y);
            Thread.Sleep(500);
            sendMouseRightclick(appclose);
            Thread.Sleep(1000);
            sendMouseLeftclick(appclose);
            Thread.Sleep(4000);
            SetCursorPos(appstart.X, appstart.Y);
            //Thread.Sleep(2500);
            sendMouseLeftclick(appstart);
            //Thread.Sleep(500);
        }

        public static void ClickAd(Point AdPoint)
        {

            SetCursorPos(AdPoint.X, AdPoint.Y);
            Thread.Sleep(500);
            sendMouseLeftclick(AdPoint); 
        }
        public static void ResetAd(Point appReset, Point appReset1, Point appReset2, Point appReset3)
        {

            SetCursorPos(appReset.X, appReset.Y);
            Thread.Sleep(500);
            sendMouseRightclick(appReset);
            Thread.Sleep(2500);

            //click to App reset
            //SetCursorPos(appReset.X, appReset.Y);
            //Thread.Sleep(1000);
            sendMouseLeftclick(appReset);
            Thread.Sleep(4000);

            //click reset point 1
            SetCursorPos(appReset1.X, appReset1.Y);
            Thread.Sleep(300);
            sendMouseLeftclick(appReset1);
            Thread.Sleep(2000);

            //click reset point 2
            SetCursorPos(appReset2.X, appReset2.Y);
            Thread.Sleep(300);
            sendMouseLeftclick(appReset2);
            Thread.Sleep(2000);

            //click reset point 3
            SetCursorPos(appReset3.X, appReset3.Y);
            Thread.Sleep(300);
            sendMouseLeftclick(appReset3);

        }

        #region mouse
        static void sendMouseLeftclick(Point p)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
        }
        static void sendMouseRightclick(Point p)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, p.X, p.Y, 0, 0);
        }

        static void sendMouseDoubleClick(Point p)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);

            Thread.Sleep(150);

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
        }

        static void sendMouseRightDoubleClick(Point p)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, p.X, p.Y, 0, 0);

            Thread.Sleep(150);

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, p.X, p.Y, 0, 0);
        }
      

        //private void btGetPoint_Click(object sender, EventArgs e)
        //{
        //    if (!_isGetPoint)
        //    {
        //        HookManager.MouseMove += new MouseEventHandler(MouseMoved);
        //        labpoint.Visible = true;
        //        _isGetPoint = true;
        //    }
        //    else
        //    {
        //        HookManager.MouseMove -= new MouseEventHandler(MouseMoved);
        //        labpoint.Visible = false;
        //        _isGetPoint = false;
        //    }

        //}
        #endregion
    }
}