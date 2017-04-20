using System;
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
            try
            {


                string VNCPath = Application.StartupPath + "\\VNC\\" + ip + ".vnc";
                Process.Start(VNCPath);
            }
            catch
            { }
        }

        public static void HomePress(BindingList<VNC> VNCList)
        {
            foreach (var item in VNCList)
            {
                try
                {
                    if (item.IP != null)
                        if (item.IP.Trim() != string.Empty)
                        {
                            OpenVNCFile(NewConfig.Config.DefaultIP + item.IP);
                            Thread.Sleep((int)NewConfig.Config.waitTime);
                            //Point app = GetPointRandonApp(Convert.ToInt32("0" + txtslapp.Text));

                            VNCHomePress(NewConfig.Config.AppPoint, NewConfig.Config.AdPoint);

                            Thread.Sleep(5000);
                            Process p = Process.GetProcessesByName(NewConfig.Config.VNCName)[0];
                            if (p != null)
                                p.Kill();
                        }
                }
                catch
                {

                }

            }

        }
        //phuong edit
        public static void OpenApps(BindingList<VNC> VNCList,int numApp, bool clickAd,bool isTrungGian,int sobuoc, bool ResetNormal=false)
        {
            foreach (var item in VNCList)
            {
                try
                {
                    if (item.IP != null)
                        if (item.IP.Trim() != string.Empty)
                        {
                            OpenVNCFile(NewConfig.Config.DefaultIP + item.IP);
                            Thread.Sleep((int)NewConfig.Config.waitTime);
                            //Point app = GetPointRandonApp(Convert.ToInt32("0" + txtslapp.Text));

                            if (clickAd)
                            {
                                ClickAd(NewConfig.Config.AdPoint);
                            }
                            else
                            {
                                //reset normal or PMP
                                if (ResetNormal)
                                {
                                    NewResetAd(NewConfig.Config.ClosePoint, NewConfig.Config.AdvertisingPoint, NewConfig.Config.AdvertisingPoint1, NewConfig.Config.AdvertisingPoint2);
                                }
                                if (isTrungGian)
                                    ClickTrungGian222(sobuoc,NewConfig.Config.ClosePoint);

                                CloseAndRestart(numApp, NewConfig.Config.AppPoint, NewConfig.Config.ClosePoint,sobuoc, ResetNormal);
                            }

                            Thread.Sleep(1000);
                            Process p = Process.GetProcessesByName(NewConfig.Config.VNCName)[0];
                            if (p != null)
                                p.Kill();
                        }
                }
                catch
                {

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
                if (item.IP != null && item.IP != string.Empty)
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

                   



                    //setting

                    Config.SettingPoint = new Point(Config.VNCPoint.X + Config.SettingPoint.X, Config.VNCPoint.Y + Config.SettingPoint.Y);

                  


                    ///privacy

                    Config.AdvertisingPoint = new Point(Config.VNCPoint.X + Config.AdvertisingPoint.X, Config.VNCPoint.Y + Config.AdvertisingPoint.Y);

                    Config.AdvertisingPoint1 = new Point(Config.VNCPoint.X + Config.AdvertisingPoint1.X, Config.VNCPoint.Y + Config.AdvertisingPoint1.Y);

                    Config.AdvertisingPoint2 = new Point(Config.VNCPoint.X + Config.AdvertisingPoint2.X, Config.VNCPoint.Y + Config.AdvertisingPoint2.Y);

                    

                    Config.s1 = new Point(Config.VNCPoint.X + Config.s1.X, Config.VNCPoint.Y + Config.s1.Y);
                    Config.s2 = new Point(Config.VNCPoint.X + Config.s2.X, Config.VNCPoint.Y + Config.s2.Y);
                    Config.s3 = new Point(Config.VNCPoint.X + Config.s3.X, Config.VNCPoint.Y + Config.s3.Y);
                    Config.s4 = new Point(Config.VNCPoint.X + Config.s4.X, Config.VNCPoint.Y + Config.s4.Y);
                    Config.s5 = new Point(Config.VNCPoint.X + Config.s5.X, Config.VNCPoint.Y + Config.s5.Y);
                    Config.s6 = new Point(Config.VNCPoint.X + Config.s6.X, Config.VNCPoint.Y + Config.s6.Y);

                    Config.s7 = new Point(Config.VNCPoint.X + Config.s7.X, Config.VNCPoint.Y + Config.s7.Y);
                    Config.s8 = new Point(Config.VNCPoint.X + Config.s8.X, Config.VNCPoint.Y + Config.s8.Y);
                    Config.s9 = new Point(Config.VNCPoint.X + Config.s9.X, Config.VNCPoint.Y + Config.s9.Y);
                    Config.s10 = new Point(Config.VNCPoint.X + Config.s10.X, Config.VNCPoint.Y + Config.s10.Y);

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
            //if (listVNC.Count == 0)
            //    listVNC.Add(new VNC());
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
        public static void CloseAndRestart(int numApp,Point appstart, Point appclose,int sobuoc, bool ResetAd = false)
        {
            try
            {
                SetCursorPos(appstart.X, appstart.Y);
                Thread.Sleep(500);
                sendMouseRightclick(appstart);
                Thread.Sleep(2000);
                //sendMouseRightclick(appstart);


                if (!ResetAd)
                {
                    SetCursorPos(appclose.X, appclose.Y);
                    Thread.Sleep(200);
                    sendMouseLeftclick(appclose);
                    Thread.Sleep(4000);



                }

                else
                {
                    Thread.Sleep(200);
                }

                Point RealAppPoint = new Point(appstart.X, appstart.Y);

                if (numApp > 1)
                {

                    Random random = new Random();
                    int randomNumber = random.Next(0, numApp);
                    RealAppPoint.X += randomNumber * 75;
                }

              

                SetCursorPos(RealAppPoint.X, RealAppPoint.Y);
                Thread.Sleep(200);
                sendMouseLeftclick(RealAppPoint);
            }
            catch
            {

            }
        }

        public static void ClickTrungGian(int sobuoc)
        {
            List<Point> listPoint = new List<Point>();
          //  Point[] listPoint = new Point[10];
            listPoint.Add(NewConfig.Config.s1);
            listPoint.Add(NewConfig.Config.s2);
            listPoint.Add(NewConfig.Config.s3);
            listPoint.Add(NewConfig.Config.s4);
            listPoint.Add(NewConfig.Config.s5);

            listPoint.Add(NewConfig.Config.s6);
            listPoint.Add(NewConfig.Config.s7);
            listPoint.Add(NewConfig.Config.s8);
            listPoint.Add(NewConfig.Config.s9);
            listPoint.Add(NewConfig.Config.s10);
            Point[] arr = listPoint.ToArray();
            for(int i=0;i<sobuoc;i++)
            {
                Point p = new Point();
                p = arr[i];
                SetCursorPos(p.X,p.Y);
                Thread.Sleep(3000);
                sendMouseLeftclick(p);

            }
            
        }

        public static void ClickTrungGian222(int sobuoc, Point appclose)
        {
            SetCursorPos(appclose.X, appclose.Y);
            Thread.Sleep(500);
            sendMouseRightclick(appclose);
           
            Thread.Sleep(200);
            sendMouseLeftclick(appclose);
            Thread.Sleep(4000);


            SetCursorPos(NewConfig.Config.s1.X, NewConfig.Config.s1.Y);
            Thread.Sleep(7000);
            sendMouseLeftclick(NewConfig.Config.s1);


            SetCursorPos(NewConfig.Config.s2.X, NewConfig.Config.s2.Y);
            Thread.Sleep(7000);
            sendMouseLeftclick(NewConfig.Config.s2);


            SetCursorPos(NewConfig.Config.s3.X, NewConfig.Config.s3.Y);
            Thread.Sleep(7000);
            sendMouseLeftclick(NewConfig.Config.s3);


            SetCursorPos(NewConfig.Config.s4.X, NewConfig.Config.s4.Y);
            Thread.Sleep(7000);
            sendMouseLeftclick(NewConfig.Config.s4);


            SetCursorPos(NewConfig.Config.s5.X, NewConfig.Config.s5.Y);
            Thread.Sleep(7000);
            sendMouseLeftclick(NewConfig.Config.s5);




            //end

            Thread.Sleep(1000);
            sendMouseRightclick(NewConfig.Config.s5);
        }


        public static void VNCHomePress(Point appstart,Point AdPoint)
        {
            try
            {
                SetCursorPos(190, 48);

                Thread.Sleep(1000);
                sendMouseLeftclick(new Point(190, 48));
                Thread.Sleep(2000);

                SetCursorPos(appstart.X, appstart.Y);
                Thread.Sleep(100);
                sendMouseRightclick(appstart);
              
            }
            catch
            {

            }
        }

        public static void ClickAd(Point AdPoint)
        {

            SetCursorPos(AdPoint.X, AdPoint.Y);
            Thread.Sleep(500);
            sendMouseLeftclick(AdPoint); 
        }
        public static void ResetAd(Point ClosePoint,Point appReset, Point appReset1, Point appReset2, Point appReset3)
        {
             
            SetCursorPos(ClosePoint.X, ClosePoint.Y);
            Thread.Sleep(500);
            sendMouseRightclick(ClosePoint);
            Thread.Sleep(2500);
            sendMouseLeftclick(ClosePoint);
            Thread.Sleep(5000);
            //click to App reset
            SetCursorPos(appReset.X, appReset.Y);
            //Thread.Sleep(1000);
            sendMouseLeftclick(appReset);
            Thread.Sleep(6500);

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
        //public static void NormalReset(Point ClosePoint,Point SettingPoint, Point Point1,Point Point2,Point Point3)
        //{
 
        //        SetCursorPos(ClosePoint.X, ClosePoint.Y);
        //        Thread.Sleep(500);
        //        sendMouseRightclick(ClosePoint);
        //        Thread.Sleep(2500);
        //        sendMouseLeftclick(ClosePoint);
        //        Thread.Sleep(5000);


        //        //click to Setting
        //        SetCursorPos(SettingPoint.X, SettingPoint.Y);
        //        //Thread.Sleep(1000);
        //        sendMouseLeftclick(SettingPoint);
        //        Thread.Sleep(3000);


        //        //mouse drag 1
        //        SetCursorPos(Point1.X, Point1.Y); Thread.Sleep(3000);
        //        LeftMouseDown(Point1);

        //        SetCursorPos(Point1.X, Point1.Y - 10);
        //        Point TempP = new Point(Point1.X, Point1.Y - 10);
        //        LeftMouseUp(TempP);


        //        //click privacy
        //        Thread.Sleep(3000);
        //        SetCursorPos(TempP.X, TempP.Y);
        //        sendMouseLeftclick(TempP);


        //        //mouse drag 2
        //        SetCursorPos(Point1.X, Point1.Y); Thread.Sleep(3000);
        //        LeftMouseDown(Point1);

        //        SetCursorPos(Point1.X, Point1.Y - 10);
        //        Point Temp2 = new Point(Point1.X, Point2.Y - 10);
        //        LeftMouseUp(Temp2);

        //        //click Advertising
        //        Thread.Sleep(3000);
        //        SetCursorPos(Point1.X, Point1.Y);
        //        sendMouseLeftclick(Point1);

              

        //        //click reset Advertising Identifier
        //        Thread.Sleep(2000);

        //        SetCursorPos(Point2.X, Point2.Y);
        //        sendMouseLeftclick(Point2);


        //        //click reset Advertising Identifier
        //        Thread.Sleep(2000);
        //        SetCursorPos(Point3.X, Point3.Y);
        //        sendMouseLeftclick(Point3);
 
           

        //}

        public static void NewResetAd(Point ClosePoint, Point AdvertisingPoint, Point AdvertisingPoint1, Point AdvertisingPoint2)
        {
            try
            {
                SetCursorPos(ClosePoint.X, ClosePoint.Y);
                Thread.Sleep(1000);
                sendMouseRightclick(ClosePoint);
                Thread.Sleep(2500);
                //SetCursorPos(ClosePoint.X, ClosePoint.Y);
                //sendMouseRightclick(ClosePoint);
                Thread.Sleep(200);
                sendMouseLeftclick(ClosePoint);
                Thread.Sleep(4000);


                //double click to status bar

                SetCursorPos(AdvertisingPoint.X, AdvertisingPoint.Y);
                sendMouseLeftclick(AdvertisingPoint);
                Thread.Sleep(180);
                sendMouseLeftclick(AdvertisingPoint);




                //click adpoint 1
                Thread.Sleep(6000);
                SetCursorPos(AdvertisingPoint1.X, AdvertisingPoint1.Y);
                sendMouseLeftclick(AdvertisingPoint1);


                //click adpoint 2
                SetCursorPos(AdvertisingPoint2.X, AdvertisingPoint2.Y);
                Thread.Sleep(2500);

                sendMouseLeftclick(AdvertisingPoint2);
            }
            catch
            { }
            


        }

        //public static void PrivacyIconReset(Point ClosePoint,Point SettingPoint, Point PrivacyAppPoint, Point Point1, Point Point2)
        //{
        //    Thread.Sleep(2000);
        //    SetCursorPos(ClosePoint.X, ClosePoint.Y);
        //    Thread.Sleep(500);
        //    sendMouseRightclick(ClosePoint);
        //    Thread.Sleep(800);
        //    sendMouseRightclick(ClosePoint);
        //    Thread.Sleep(300);
        //    sendMouseLeftclick(ClosePoint);
        //    Thread.Sleep(3500);


          

        //    //click to Setting
        //    SetCursorPos(SettingPoint.X, SettingPoint.Y);
        //    sendMouseLeftclick(SettingPoint);
        //    Thread.Sleep(2500);

         

        //    //click PrivacyAppPoint
        //    SetCursorPos(PrivacyAppPoint.X, PrivacyAppPoint.Y);
        //    sendMouseRightclick(PrivacyAppPoint);
        //    Thread.Sleep(3000);
        //    sendMouseLeftclick(PrivacyAppPoint);


        //    //mouse drag 1
        //    SetCursorPos(Point1.X, Point1.Y);
        //    Thread.Sleep(4000);
        //    LeftMouseDown(Point1);
        //   //Thread.Sleep(150);
        //    SetCursorPos(Point1.X, Point1.Y - 100);
        //    //Thread.Sleep(150);
        //    SetCursorPos(Point1.X, Point1.Y - 200);
                   
        //    Point TempP = new Point(Point1.X, Point1.Y - 200);
        //    LeftMouseUp(TempP);

        //    Thread.Sleep(1000);
        //    SetCursorPos(Point1.X, Point1.Y);
        //    LeftMouseDown(Point1);
        //    //Thread.Sleep(150);
        //    SetCursorPos(Point1.X, Point1.Y - 50);
        //    //Thread.Sleep(150);
        //    SetCursorPos(Point1.X, Point1.Y - 100);

        //    Point TempP1 = new Point(Point1.X, Point1.Y - 100);
        //    LeftMouseUp(TempP1);
 

        

        //    //click Advertising
        //    Thread.Sleep(3000);
        //    SetCursorPos(Point1.X, Point1.Y);
        //    sendMouseLeftclick(Point1);



        //    //click reset Advertising Identifier
        //    Thread.Sleep(2000);
        //    SetCursorPos(Point2.X, Point2.Y);
        //    sendMouseLeftclick(Point2);

        //    Thread.Sleep(2000);



        //    //click reset  
        //    SetCursorPos(Point1.X, Point1.Y-3);
        //    Thread.Sleep(2000);         
        //    sendMouseLeftclick(Point1);



        //}
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

        static public void LeftMouseDown(Point p)
        {
            // Simulate left down, notice that RELATIVE movement is 0
            mouse_event(MOUSEEVENTF_LEFTDOWN, p.X, p.Y, 0, 0);
        }

        static public void LeftMouseUp(Point p)
        {
            // Simulate left up, notice that RELATIVE movement is 0 too
            mouse_event(MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
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
