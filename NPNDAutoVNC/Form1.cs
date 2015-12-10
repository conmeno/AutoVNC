using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Gma.UserActivityMonitor;
//using WindowsInput;

namespace NPNDAutoVNC
{
    public partial class Form1 : Form
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

        private bool _isGetPoint=false;
        private Queue<Int32> _listQty = new Queue<int>();
        private List<Int32> _listQty24=new List<int>();
        private Queue<string> _ShowAdCurr = new Queue<string>();
        private bool _isstart = false;
        int _currentHour = 0;
        private bool _isRestartAppOK = true;
        int _countCloseAd=59;
        bool _isstop = false;
        #endregion

        #endregion

        public Form1()
        {
            InitializeComponent();
            //CallVNC
            //Process.Start(CTLConfig._PathVNC);
            //Thread.Sleep(Convert.ToInt32(CTLConfig._Sleep));
            //input ip to vnc
            //setValueControlByHandle(Process.GetProcessesByName(CTLConfig._ProcessName)[0],Convert.ToInt32(CTLConfig._ControlIDIP), "10.10.11.112");
            //input pass
            //setValueControlByHandle(Process.GetProcessesByName(CTLConfig._ProcessName)[0], Convert.ToInt32(CTLConfig._ControlIDPass), "1");
            txt1to24.Text = CTLConfig._Time1to24;
            loadMain();
            
        }
        public void MouseMoved(object sender, MouseEventArgs e)
        {
            labpoint.Text = String.Format("x={0}  y={1}", e.X, e.Y);
            //if (e.Clicks > 0) LogWrite("MouseButton     - " + e.Button.ToString());
        }
        public void loadMain()
        {
            //DataSet dt = new DataSet();
            //dt.ReadXml(Path.Combine(Application.StartupPath, "Funtion.xml"));
            DataSet dtlist = new DataSet();
            dtlist.ReadXml(Path.Combine(Application.StartupPath, "list.xml"));
            //DataTable dt= LoadCSVList("_list.csv");
            //gridfuntion.DataSource = dt.Tables[0];
            gridlist.DataSource = dtlist.Tables[0];
            string[] strqty = CTLConfig._Time1to24.Split(',');
            foreach (string x in strqty)
            {
                _listQty24.Add(Convert.ToInt32(x));
            }
            txtwidth.Text = CTLConfig._WidthApp.ToString();
            txthight.Text = CTLConfig._hightApp.ToString();
            txtslapp.Text = CTLConfig._SLApp.ToString();
        }
        public void LoadIP()
        {
            DataTable dtip=new DataTable();
            dtip = CTLImportFileCSV.ReadFromCsv(Path.Combine(Application.StartupPath, "List.csv"), Encoding.ASCII, ',');
            gridlist.DataSource = dtip;
        }

        public DataTable InitFuntion()
        {
            DataTable dataTable=new DataTable("funtion");
            dataTable.Columns.Add("Des");
            dataTable.Columns.Add("X");
            dataTable.Columns.Add("Y");
            dataTable.Columns.Add("CtrID");
            dataTable.Columns.Add("MemID");
            for (int i = 0; i < 5; i++)
            {
                DataRow r = dataTable.NewRow();
                r["Des"] = "InputIP";
                r["X"] = "10";
                r["Y"] = "10";
                r["CtrID"] = "1";
                r["MemID"] = "1";
                dataTable.Rows.Add(r);
            }
           

            return dataTable;
        }
        public DataTable InitList()
        {
            DataTable dataTable = new DataTable("List");
            dataTable.Columns.Add("IP");
            dataTable.Columns.Add("Action");
            for (int i = 0; i < 5; i++)
            {
                DataRow r = dataTable.NewRow();
                r["IP"] = "192.168.1.20";
                r["Action"] = "0";
                dataTable.Rows.Add(r);
            }


            return dataTable;
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                _isstop = false;
                timer5p.Enabled = false;
                timer5p.Stop();
                timer5p.Tick -= new EventHandler(timer5p_Tick);
                timer10p.Enabled = false;
                timer10p.Stop();
                timer10p.Tick -= new EventHandler(timer10p_Tick);
                if (checkBoxIsStartApp.Checked)
                    StartAndrestartApp();
                if (checkBoxStartAndClose.Checked)// restar app
                {
                    //timerRestartApp.Enabled = true;
                    //timerRestartApp.Interval = (int)numTick.Value;
                    ////timerRestartApp.Tick += new EventHandler(timerRestartApp_Tick);
                    lookuprestartapp();
                }
                else//click ad
                {
                    //timerRestartApp.Enabled = false;
                    //timerGiay.Enabled = true;
                    //timerGiay.Tick += new EventHandler(timerGiay_Tick);
                    //tinh so luong trong gio
                    int currentM = 60 - DateTime.Now.Minute;
                    int soluongCurrentM = ((currentM * 10 / 6) * _listQty24[DateTime.Now.Hour]) / 100;
                    CtlError.WriteError("start click ", soluongCurrentM.ToString());
                    if (soluongCurrentM > 30)
                    {
                        Gen5p(soluongCurrentM);
                        CtlError.WriteError("Gen5 ", _listQty.Count.ToString());
                        int x = _listQty.Count;
                        timer5p.Enabled = true;
                        timer5p.Tick += new EventHandler(timer5p_Tick);
                        timer5p_Tick(null, null);
                    }
                    else if (soluongCurrentM > 0)
                    {
                        Gen10p(soluongCurrentM);
                        CtlError.WriteError("Gen10 ", _listQty.Count.ToString());
                        timer10p.Enabled = true;
                        timer10p.Tick += new EventHandler(timer10p_Tick);
                        timer10p_Tick(null, null);
                    }
                }
            }
            catch
            {
            }
            timerGiay.Enabled = true;
            timerGiay.Tick+=new EventHandler(timerGiay_Tick);
            timerGiay.Start();
            btStop.Enabled = true;
            btStart.Enabled = false;
        }
        void setValueControlByHandle(Process p,int ID, string valueIP)
        {
            try
            {
                Thread.Sleep(1000);
                IntPtr mainhan = p.MainWindowHandle;

                List<WindowScrape.Types.HwndObject> arr, arr1;
                arr = WindowScrape.Types.HwndObject.GetWindows();                
                int mainInt = -1;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i].Hwnd == mainhan)
                    {
                        mainInt = i;
                        break;
                    }

                }
                arr1 = arr[mainInt].GetChildren();

                
                int han = -1;

                for (int i = 0; i < arr1.Count; i++)
                {
                    int controlID = GetDlgCtrlID(arr1[i].Hwnd);

                    if (controlID == ID)
                    {
                        han = i;
                        break;
                    }
                }

                arr1[han].Text = valueIP;
            }
            catch (Exception ex)
            {
                CtlError.WriteError("ErroLog", "setValueControlByHandle Loi khi set handle tren form", ex.Message);
                return;
            }
        }
        void setValueControlByHandleByTitle(Process p, int ID, string valueIP,string title)
        {
            try
            {
                Thread.Sleep(1000);
                IntPtr mainhan = p.MainWindowHandle;

                List<WindowScrape.Types.HwndObject> arr1;
                WindowScrape.Types.HwndObject arr;
                //arr = WindowScrape.Types.HwndObject.GetWindows;
                arr = WindowScrape.Types.HwndObject.GetWindowByTitle(title);
                
                int mainInt = -1;

                //for (int i = 0; i < arr.Count; i++)
                //{
                //    if (arr[i].Hwnd == mainhan)
                //    {
                //        mainInt = i;
                //        break;
                //    }

                //}
                arr1 = arr.GetChildren();


                int han = -1;

                for (int i = 0; i < arr1.Count; i++)
                {
                    int controlID = GetDlgCtrlID(arr1[i].Hwnd);

                    if (controlID == ID)
                    {
                        han = i;
                        break;
                    }
                }

                arr1[han].Text = valueIP;
            }
            catch (Exception ex)
            {
                CtlError.WriteError("ErroLog", "setValueControlByHandle Loi khi set handle tren form", ex.Message);
                return;
            }
        }
        IntPtr GetValueControlByHandle(Process p, int ID)
        {
            try
            {
                IntPtr mainhan = p.MainWindowHandle;

                List<WindowScrape.Types.HwndObject> arr, arr1;
                arr = WindowScrape.Types.HwndObject.GetWindows();
                int mainInt = -1;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i].Hwnd == mainhan)
                    {
                        mainInt = i;
                        break;
                    }

                }
                arr1 = arr[mainInt].GetChildren();

                IntPtr ptrhan =(IntPtr) 0;
                int han = -1;

                for (int i = 0; i < arr1.Count; i++)
                {
                    int controlID = GetDlgCtrlID(arr1[i].Hwnd);

                    if (controlID == ID)
                    {
                        han = i;
                        ptrhan = arr1[i].Hwnd;
                        break;
                    }
                }

                return (IntPtr) ptrhan;
            }
            catch (Exception ex)
            {
                CtlError.WriteError("ErroLog", "setValueControlByHandle Loi khi set handle tren form", ex.Message);
                return (IntPtr)0;
            }
        }
        IntPtr GetValueControlByHandle(Process p, int ID,string title)
        {
            try
            {
                Thread.Sleep(1000);
                IntPtr mainhan = p.MainWindowHandle;

                List<WindowScrape.Types.HwndObject> arr1;
                WindowScrape.Types.HwndObject arr;
                //arr = WindowScrape.Types.HwndObject.GetWindows;
                arr = WindowScrape.Types.HwndObject.GetWindowByTitle(title);

                int mainInt = -1;

                //for (int i = 0; i < arr.Count; i++)
                //{
                //    if (arr[i].Hwnd == mainhan)
                //    {
                //        mainInt = i;
                //        break;
                //    }

                //}
                arr1 = arr.GetChildren();

                IntPtr ptrhan =(IntPtr) 0;
                int han = -1;

                for (int i = 0; i < arr1.Count; i++)
                {
                    int controlID = GetDlgCtrlID(arr1[i].Hwnd);

                    if (controlID == ID)
                    {
                        han = i;
                        ptrhan = arr1[i].Hwnd;
                        break;
                        
                    }
                }

                return ptrhan;
            }
            catch (Exception ex)
            {
                CtlError.WriteError("ErroLog", "get ValueControlByHandle by title Loi khi set handle tren form", ex.Message);
                return (IntPtr)0;
            }
        }
        //public void ClickPoint(int x,int y,int MouseEven)
        //{
        //    //int x = Convert.ToInt16(txtX.Text);//set x position 
        //    //int y = Convert.ToInt16(txtY.Text);//set y position 
        //    Cursor.Position = new Point(x, y);
        //    mouse_event(MouseEven, 0, 0, 0, 0);//make left button down
        //    //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);//make left button up
        //}
        //public void DoubleClickPoint(int x,int y, int MouseEven)
        //{
        //    Cursor.Position = new Point(x, y);
        //}

       

        #region 

        public bool Save_FileListIP()
        {
            try
            {
                string stLine = "IP,Action";
                DataTable dt = (DataTable)gridlist.DataSource;
                using (StreamWriter MyFile = new StreamWriter(Path.Combine(Application.StartupPath, "list.csv")))
                {
                    MyFile.WriteLine(stLine);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        stLine = "";
                        if (dt.Rows[i]["IP"].ToString().Trim() != string.Empty)
                        {
                            stLine = dt.Rows[i]["IP"].ToString().Trim() + "," + dt.Rows[i]["Action"].ToString().Trim();
                            MyFile.WriteLine(stLine);
                        }
                    }
                    //MessageBox.Show("Information of all the files are successfully saved in the following location: \n" + Application.StartupPath + "\\output.csv", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                CtlError.WriteError("export csv ip", ex.Message);
                return false;
                throw new Exception(ex.Message);
            }
        }
        public DataTable LoadCSVList(string filetable)
        {
            DataTable dt = new DataTable();
            try
            {
                // You can get connected to driver either by using DSN or connection string

                // Create a connection string as below, if you want to use DSN less connection. The DBQ attribute sets the path of directory which contains CSV files
                string strConnString = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=" + Application.StartupPath.Trim() + ";Extensions=asc,csv,tab,txt;Persist Security Info=False";
                string sql_select;
                System.Data.Odbc.OdbcConnection conn;

                //Create connection to CSV file
                conn = new System.Data.Odbc.OdbcConnection(strConnString.Trim());

                // For creating a connection using DSN, use following line
                //conn	=	new System.Data.Odbc.OdbcConnection(DSN="MyDSN");

                //Open the connection 
                conn.Open();
                //Fetch records from CSV
                sql_select = "select * from [" + filetable + "]";

                obj_oledb_da = new System.Data.Odbc.OdbcDataAdapter(sql_select, conn);
                //Fill dataset with the records from CSV file
                obj_oledb_da.Fill(dt);
        
                conn.Close();
            }
            catch (Exception e) //Error
            {
                CtlError.WriteError("Loi load CSV file ",e.Message);
                return dt;
            }
            return dt;
        }
        #endregion

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)
            {
                //save point
                CTLConfig.SetSLApp(txtslapp.Text);
            }
            else if(e.KeyCode==Keys.F2)
            {
                CTLConfig.SetWidthApp(txtwidth.Text);
            }
            else if(e.KeyCode==Keys.F3)
            {
                CTLConfig.SetHightApp(txthight.Text);
            }
        }

        #region Xuly start-close
        public void Startad(Point Pad)
        {
            Thread.Sleep(2000);
            SetCursorPos(Pad.X,Pad.Y);
            Thread.Sleep(500);
            sendMouseLeftclick(Pad);
        }
        public void CloseAndRestart(Point RightClick,Point appstart,Point appclose)
        {
            SetCursorPos(RightClick.X,RightClick.Y);
            Thread.Sleep(500);
            sendMouseRightclick(RightClick);
            Thread.Sleep(2500);
            SetCursorPos(appclose.X, appclose.Y);
            Thread.Sleep(1000);
            sendMouseLeftclick(appclose);
            Thread.Sleep(2500);
            SetCursorPos(appstart.X, appstart.Y);
            Thread.Sleep(2500);
            sendMouseLeftclick(appstart);
            //Thread.Sleep(500);
        }
        public void ResetAd(Point RightClick, Point appReset, Point appReset1, Point appReset2, Point appReset3)
        {
            SetCursorPos(RightClick.X, RightClick.Y);
            Thread.Sleep(500);
            sendMouseRightclick(RightClick);
            Thread.Sleep(2500);

            //click to App reset
            SetCursorPos(appReset.X, appReset.Y);
            Thread.Sleep(1000);
            sendMouseLeftclick(appReset);
            Thread.Sleep(2000);

            //click reset point 1
            SetCursorPos(appReset1.X, appReset1.Y);
            Thread.Sleep(1000);
            sendMouseLeftclick(appReset1);
            Thread.Sleep(2000);

            //click reset point 2
            SetCursorPos(appReset2.X, appReset2.Y);
            Thread.Sleep(1000);
            sendMouseLeftclick(appReset2);
            Thread.Sleep(2000);

            //click reset point 3
            SetCursorPos(appReset3.X, appReset3.Y);
            Thread.Sleep(1000);
            sendMouseLeftclick(appReset3);
            
        }
        #endregion

        
        #region Xu ly timemer


        #endregion 


        #region xu ly timeTick
        //s
        private void timerGiay_Tick(object sender, EventArgs e)
        {          
            if(DateTime.Now.Minute==0&&_currentHour!=DateTime.Now.Hour)
            {
                CtlError.WriteError("timer giay Click ","con lai " +_listQty.Count.ToString());
                timer5p.Enabled = false;
                timer5p.Stop();
                timer10p.Enabled = false;
                timer10p.Stop();
                timerphut.Enabled = false;
                timerphut.Stop();
                _isstart = true;
                _listQty.Clear();
                _currentHour = DateTime.Now.Hour;
                btStart_Click(null, null);
                _currentHour = DateTime.Now.Hour;
            }
        }
        //p
        private void timerphut_Tick(object sender, EventArgs e)
        {
            while (_ShowAdCurr.Count>0)
            {
                CloseAd(_ShowAdCurr.Dequeue());
                Thread.Sleep(1000);
                Process p = Process.GetProcessesByName(CTLConfig._ProcessName)[0];
                if (p != null)
                    p.Kill();
            }

            timerGiay.Enabled = false;
        }
        // 5 p
        private void timer5p_Tick(object sender, EventArgs e)
        {
            if (_listQty == null || _listQty.Count <= 1)
                return;
            int slClick = _listQty.Dequeue();
            DataTable dt = (DataTable)gridlist.DataSource;
            List<int> indexloaibo = new List<int>();
            Random ran = new Random();
            for (int i = 0; i < slClick; i++)
            {
                int indexip = dt.Rows.Count;
                int indexget = ran.Next(0,indexip);
                while (indexloaibo.Contains(indexget))
                {
                    indexget = ran.Next();
                }
                string ip = dt.Rows[indexget]["IP"].ToString();
                SetVNCByIP(ip);
                Thread.Sleep(2500);
                //ClickAd(ip);
                Startad(CTLConfig._PointAD);
                _ShowAdCurr.Enqueue(ip);
                CtlError.WriteError("Click may ", ip);
                Thread.Sleep(1000);
                Process p = Process.GetProcessesByName(CTLConfig._ProcessName)[0];
                if (p != null)
                    p.Kill();
            }
            //timerphut.Enabled = true;
            //timerphut.Tick += new EventHandler(timerphut_Tick);
            //timer5p.Enabled = false;
            _countCloseAd = 59;
            timerCount.Interval = 1000;
            timerCount.Enabled = true;
            timerCount.Start();
            timerCount.Tick += new EventHandler(timerCount_Tick);
        }
        //10 9
        private void timer10p_Tick(object sender, EventArgs e)
        {
            if (_listQty == null || _listQty.Count <= 1)
                return;
            int slClick = _listQty.Dequeue();
            DataTable dt =(DataTable) gridlist.DataSource;
            List<int> indexloaibo=new List<int>();
            Random ran=new Random();
            for (int i = 0; i < slClick; i++)
            {
                int indexip = dt.Rows.Count;
                int indexget = ran.Next(0,indexip);
                while (indexloaibo.Contains(indexget))
                {
                    indexget = ran.Next(0, indexip);
                }
                string ip = dt.Rows[indexget]["IP"].ToString();
                SetVNCByIP(ip);
                Thread.Sleep(2500);
                              
                //ClickAd(ip);
                Startad(CTLConfig._PointAD);
                _ShowAdCurr.Enqueue(ip);
                CtlError.WriteError("Click may ", ip);
                Thread.Sleep(1000);
                Process p = Process.GetProcessesByName(CTLConfig._ProcessName)[0];
                if(p!=null)
                    p.Kill();
            }
            //timerphut.Enabled = true;
            //timerphut.Tick += new EventHandler(timerphut_Tick);
            //timer10p.Enabled = false;
            _countCloseAd = 59;
            timerCount.Interval = 1000;
            timerCount.Enabled = true;
            timerCount.Start();
            timerCount.Tick+=new EventHandler(timerCount_Tick);
        }
        #endregion
        #region xu ly click
        //public void ClickAd(string ip)
        //{
        //    //CallVNC
        //    //Process.Start(CTLConfig._PathVNC);
        //    //Thread.Sleep(Convert.ToInt32(CTLConfig._Sleep));
        //    ////input ip to vnc
        //    //setValueControlByHandle(Process.GetProcessesByName(CTLConfig._ProcessName)[0],Convert.ToInt32(CTLConfig._ControlIDIP), ip);
        //    //////Click button Connect
        //    //Thread.Sleep(1000);
        //    //Process[] vnc= Process.GetProcessesByName(CTLConfig._ProcessName);
        //    //IntPtr handleButton = FindWindowEx(vnc[0].MainWindowHandle, IntPtr.Zero, "Button", "Connect");
        //    //SendMessage(handleButton, BN_CLICKED, (IntPtr)0, (IntPtr)0);
        //    //////
        //    //Thread.Sleep(6000);
        //    ////input pass
        //    //string title="VNC Authentication: "+ip+" [No Encryption]";
        //    //setValueControlByHandleByTitle(Process.GetProcessesByName(CTLConfig._ProcessName)[0], Convert.ToInt32(CTLConfig._ControlIDPass), "1",title);
        //    //Thread.Sleep(2000);
        //    /////  ////Click button OK
        //    ////Process[] vnc = Process.GetProcessesByName(CTLConfig._ProcessName);
        //    ////IntPtr handleButtonOK = FindWindowEx(vnc[0].MainWindowHandle, IntPtr.Zero, "Button", "OK");
        //    //IntPtr handleButtonOK = GetValueControlByHandle(Process.GetProcessesByName(CTLConfig._ProcessName)[0], 1);
        //    //SendMessage(handleButtonOK, BN_CLICKED, (IntPtr)0, (IntPtr)0);
        //    //Thread.Sleep(1000);
        //    //
        //    // click point
        //    //SetVNCByIP(ip);
        //    Startad(CTLConfig._PointAD);

        //}

        public void CloseAd(string ip)
        {
            //CallVNC
            Process.Start(CTLConfig._PathVNC);
            Thread.Sleep(Convert.ToInt32(CTLConfig._Sleep));
            //input ip to vnc
            setValueControlByHandle(Process.GetProcessesByName(CTLConfig._ProcessName)[0], Convert.ToInt32(CTLConfig._ControlIDIP), ip);
            ////Click button Connect
            Process[] vnc = Process.GetProcessesByName(CTLConfig._ProcessName);
            IntPtr handleButton = FindWindowEx(vnc[0].MainWindowHandle, IntPtr.Zero, "Button", "Connect");
            SendMessage(handleButton, BN_CLICKED, (IntPtr)0, (IntPtr)0);
            ////

            //input pass
            Thread.Sleep(2000);
            setValueControlByHandle(Process.GetProcessesByName(CTLConfig._ProcessName)[0], Convert.ToInt32(CTLConfig._ControlIDPass), "8888");
            ///  ////Click button OK
            //Process[] vnc = Process.GetProcessesByName(CTLConfig._ProcessName);
            IntPtr handleButtonOK = FindWindowEx(vnc[0].MainWindowHandle, IntPtr.Zero, "Button", "OK");
            SendMessage(handleButton, BN_CLICKED, (IntPtr)0, (IntPtr)0);
            //
            // close
            CloseAndRestart(CTLConfig._pointRightClick,CTLConfig._PointStartApp,CTLConfig._PointAppCl);

        }
        #endregion
        #region Gennerate

        public void GennerateQty()
        {
            int QtyCurrent = _listQty24[DateTime.Now.Hour];
            if(QtyCurrent>30)
            {
                Gen5p(QtyCurrent);
                timer5p.Enabled = true;
                timer5p.Tick += new EventHandler(timer5p_Tick);
                timer5p.Start();
                timer5p_Tick(null,null);
            }
            else
            {
                Gen10p(QtyCurrent);
                timer10p.Enabled = true;
                timer10p.Start();
                timer10p.Tick += new EventHandler(timer10p_Tick);
                timer10p_Tick(null, null);
            }
        }
        public void Gen10p(int QTy)
        {
            //_listQty.Clear();

            Random ran=new Random();
            for (int i = 5; i >0; i--)
            {
                int sl = QTy/i;
                int slclick = 1;
                if (sl>2)
                {
                    slclick = ran.Next(1, QTy + 2);
                }
                else if (QTy>0)
                {
                    slclick = ran.Next(1, QTy);
                }
                _listQty.Enqueue(slclick);
                CtlError.WriteError("Gen 10 sl click ", slclick.ToString());
                QTy = QTy - slclick;
            }
        }
        public void Gen5p(int QTy)
        {
            //_listQty.Clear();
            try
            {
                Random ran = new Random();
                for (int i = 10; i > 0; i--)
                {
                    int sl = QTy / i;
                    int slclick = 1;
                    if (sl > 2)
                        slclick = ran.Next(1, QTy / 2 + 2);
                    else
                    {
                        slclick = ran.Next(1, QTy);
                    }
                    _listQty.Enqueue(slclick);
                    CtlError.WriteError("Gen 5 sl click ", slclick.ToString());
                    QTy = QTy - slclick;
                }
            }
            catch
            {
                }
        }
        #endregion

        private void btStop_Click(object sender, EventArgs e)
        {
            //if(checkBoxStartAndClose.Enabled)//restart app
            //{
                //timerRestartApp.Enabled = false;
                //timerRestartApp.Stop();
                //timerRestartApp.Tick -= new EventHandler(timerRestartApp_Tick);
            _isstop = true;
            //}
            //else//click ad
            //{
                timerGiay.Enabled = false;
                timerGiay.Stop();
                timerGiay.Tick -= new EventHandler(timerGiay_Tick);
            //}
            btStop.Enabled = false;
            btStart.Enabled = true;
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            DataTable dt =(DataTable) gridlist.DataSource;
            dt.WriteXml(Path.Combine(Application.StartupPath,"list.xml"));
            CTLConfig.Setvalue(txt1to24.Text);
        }

        private void checkBoxStartAndClose_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxStartAndClose.Checked)
            {
                numTick.Enabled = true;
            }
            else
            {
                numTick.Enabled = false;
            }
        }


        public Point GetPointRandonApp(int slapp)
        {
            Point p;
            Random ran=new Random();
            int x = ran.Next(1, slapp+1);
            if(x==1)
            {
                p = CTLConfig._PointFirtApp;
            }
            else
            {
                int w =(int) (x%4.5)-1;
                int h =(int) (x/(4.5));
                
                p=new Point(w*CTLConfig._WidthApp+CTLConfig._PointFirtApp.X,h*CTLConfig._hightApp+CTLConfig._PointFirtApp.Y);
            }
            return p;
        }
        public void SetVNCByIP(string ip)
        {
            try
            {
                //CallVNC
                Process.Start(CTLConfig._PathVNC);
                Thread.Sleep(Convert.ToInt32(2000));
                //input ip to vnc
                Process[] p = Process.GetProcessesByName(CTLConfig._ProcessName);
                setValueControlByHandle(p[0], Convert.ToInt32(CTLConfig._ControlIDIP), ip);
                ////Click button Connect
                //Process[] vnc = Process.GetProcessesByName(CTLConfig._ProcessName);
                IntPtr handleButton = FindWindowEx(p[0].MainWindowHandle, IntPtr.Zero, "Button", "Connect");
                SendMessage(handleButton, BN_CLICKED, (IntPtr)0, (IntPtr)0);
                Thread.Sleep(2000);
                //SetCursorPos(765, 493);


                ////SetCursorPos(CTLConfig._PointVNCConnect.X, CTLConfig._PointVNCConnect.Y);
                ////Point c = new Point(CTLConfig._PointVNCConnect.X, CTLConfig._PointVNCConnect.Y);
                ////sendMouseDoubleClick(c);


                ////
                //InputSimulator.SimulateTextEntry("1");

                //input pass
                //Thread.Sleep(2000);
                //SetCursorPos(734, 456);
                //c = new Point(734, 456);
                //sendMouseLeftclick(c);
                Thread.Sleep(5000);
                string title = "VNC Authentication: " + ip + " [No Encryption]";
                setValueControlByHandleByTitle(p[0], Convert.ToInt32(CTLConfig._ControlIDPass), "8888", title);


                ///  ////Click button OK
                //Process[] vnc = Process.GetProcessesByName(CTLConfig._ProcessName);
                Thread.Sleep(2000);
                //IntPtr handleButtonOK = FindWindowEx(vnc[0].MainWindowHandle, IntPtr.Zero, "Button", "OK");
                IntPtr hdBtOK= GetValueControlByHandle(p[0], 1, title);
                SendMessage(hdBtOK, BN_CLICKED, (IntPtr)0, (IntPtr)0);
                //setmouse and click ad point
                //SetCursorPos(CTLConfig._PointOK.X, CTLConfig._PointOK.Y);
                //c = new Point(CTLConfig._PointOK.X, CTLConfig._PointOK.Y);
                //sendMouseLeftclick(c);
            }
            catch
            { }
        }
        public void StartAndrestartApp()
        {
            DataTable dt = (DataTable) gridlist.DataSource;
            foreach (DataRow r in dt.Rows)
            {
                if(r["IP"].ToString()!=string.Empty)
                {
                    SetVNCByIP(r["IP"].ToString());
                    Thread.Sleep(500);
                    Point app = GetPointRandonApp(Convert.ToInt32("0" + txtslapp.Text));

                    if (checkResetAd.Checked)
                    {
                        ResetAd(CTLConfig._pointRightClick, CTLConfig._PointAppResetAd, CTLConfig._PointResetAdID1, CTLConfig._PointResetAdID2, CTLConfig._PointResetAdID3);
                    }

                    CloseAndRestart(CTLConfig._pointRightClick, app, CTLConfig._PointAppCl);
                    Thread.Sleep(1000);
                    Process p = Process.GetProcessesByName(CTLConfig._ProcessName)[0];
                    if (p != null)
                        p.Kill();
                }
              
            }
            _isRestartAppOK = true;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SetCursorPos(270, 247);
        //    Thread.Sleep(150);
        //    sendMouseDoubleClick(new Point(270, 247));

        //}

        #region mouse
        void sendMouseLeftclick(Point p)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
        }
        void sendMouseRightclick(Point p)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, p.X, p.Y, 0, 0);
        }

        void sendMouseDoubleClick(Point p)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);

            Thread.Sleep(150);

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
        }

        void sendMouseRightDoubleClick(Point p)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, p.X, p.Y, 0, 0);

            Thread.Sleep(150);

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, p.X, p.Y, 0, 0);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Point currentPoint;
            //GetCursorPos(out currentPoint);
            //gridfuntion
        }

        private void btGetPoint_Click(object sender, EventArgs e)
        {
            if (!_isGetPoint)
            {
                HookManager.MouseMove += new MouseEventHandler(MouseMoved);
                labpoint.Visible = true;
                _isGetPoint = true;
            }
            else
            {
                HookManager.MouseMove -= new MouseEventHandler(MouseMoved);
                labpoint.Visible = false;
                _isGetPoint = false;
            }

        }
        #endregion

        private void lookuprestartapp()
        {
            if(checkBoxIsStartApp.Enabled&&!_isstop)
            {
                StartAndrestartApp();
                
            }
            lookuprestartapp();
            
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            if (_countCloseAd == 0)
            {
                int x = _ShowAdCurr.Count;
                string ip;
                for (int i = 0; i < x; i++)
                {
                    ip = _ShowAdCurr.Dequeue();
                    SetVNCByIP(ip);
                    Thread.Sleep(2500);
                    Point app = GetPointRandonApp(Convert.ToInt32("0" + txtslapp.Text));
                    CloseAndRestart(CTLConfig._pointRightClick, app, CTLConfig._PointAppCl);
                    CtlError.WriteError("Close may ", ip);
                    Thread.Sleep(1000);
                    Process p = Process.GetProcessesByName(CTLConfig._ProcessName)[0];
                    if (p != null)
                        p.Kill();
                }
                timerCount.Enabled = false;
                timerCount.Stop();
            }
            _countCloseAd--;
            //CtlError.WriteError("countclose ad ", _countCloseAd.ToString());
        }

        private void btsetmouse_Click(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            for (int i = 0; i < 5; i++)
            {
                SetCursorPos((int)txtmouseX.Value, (int)txtmouseY.Value);
                Thread.Sleep(1500);
                sendMouseDoubleClick(new Point((int)txtmouseX.Value, (int)txtmouseY.Value));
            }
        }

        private void btleftclick_Click(object sender, EventArgs e)
        {
            sendMouseLeftclick(new Point((int)txtmouseX.Value,(int)txtmouseY.Value));
        }

        private void btdoubleLeftclick_Click(object sender, EventArgs e)
        {
            sendMouseDoubleClick(new Point((int)txtmouseX.Value,(int)txtmouseY.Value));
        }

        private void btRightClick_Click(object sender, EventArgs e)
        {
            sendMouseRightclick(new Point((int)txtmouseX.Value,(int)txtmouseY.Value));
        }

        private void btdoublerightClcik_Click(object sender, EventArgs e)
        {
            sendMouseRightDoubleClick(new Point((int)txtmouseX.Value,(int)txtmouseY.Value));
        }

     
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct MousePoint
    {
        public int X;
        public int Y;

        public MousePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
