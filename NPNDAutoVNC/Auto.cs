﻿using Gma.UserActivityMonitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NPNDAutoVNC
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }

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
        int LoopCount = 1;

        private void btStart_Click(object sender, EventArgs e)
        {
            BindingList<VNC> listVNC = (BindingList<VNC>)gridlist.DataSource;

            LoopOpenApps(listVNC);
        }
        public void LoopOpenApps(BindingList<VNC> listVNC)
        {
            Utility.OpenApps(listVNC,checkResetAd.Checked,false);
            LoopCount++;
            if (cbClickAd.Checked)
            {
                Thread.Sleep(30000);
                Utility.OpenApps(listVNC, checkResetAd.Checked, true);
            }
            LoopOpenApps(listVNC);

        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //Utility.SaveConfig();
        }

        private void btSaveList_Click(object sender, EventArgs e)
        {

            BindingList<VNC> listVNC = (BindingList<VNC>)gridlist.DataSource;
            //foreach (DataRow item in dt.Rows)
            //{
            //    VNC vnc = new VNC();
            //    vnc.IP = item["IP"].ToString();
            //    vnc.Status = 1;// item["Status"].ToString();
            //    vnc.Action = 1;// item["Action"].ToString();
            //    listVNC.Add(vnc);

            //}
            Utility.SaveListVNC(listVNC);
        }

        private void Auto_Load(object sender, EventArgs e)
        {
           
         LoadFirst();
        }
        public void LoadFirst()
        {
            BindingList<VNC> listVNC = Utility.LoadVNCListBind();
            gridlist.DataSource = listVNC;

            //load config
            Utility.LoadConfig();
            Utility.ListIPtoFiles(listVNC);
        }

        private void btGetPoint_Click(object sender, EventArgs e)
        {
            HookManager.MouseMove += new MouseEventHandler(MouseMoved);
            HookManager.MouseClick += HookManager_MouseClick;
        }

        void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            txtPointX.Text = e.X.ToString();
            txtPointY.Text = e.Y.ToString();

            txtVNCPointX.Text = (e.X - NewConfig.Config.VNCPoint.X).ToString() ;
            txtVNCPointY.Text=(e.Y - NewConfig.Config.VNCPoint.Y).ToString();


            HookManager.MouseClick -= HookManager_MouseClick;
        }
        public void MouseMoved(object sender, MouseEventArgs e)
        { 

            labpoint.Text = String.Format("x={0}  y={1}", e.X, e.Y);
            //if (e.Clicks > 0) LogWrite("MouseButton     - " + e.Button.ToString());
        }

        #region "Config Button Click Event"
        
        private void btSaveVNCPoint_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtPointX.Text), int.Parse(txtPointY.Text));
            config.VNCPoint = temp;
            Utility.SaveConfig(config);
        }

        private void btSaveAppPoint_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.AppPoint = temp;
            Utility.SaveConfig(config);
        }

        private void btSaveAppPoint2_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.AppPoint2 = temp;
            Utility.SaveConfig(config);
        }

        private void btSaveAdPoint_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.AdPoint = temp;
            Utility.SaveConfig(config);
        }

        private void btSaveCloseAdPoint_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.ClosePoint = temp;
            Utility.SaveConfig(config);
        }

        private void btSaveResetAppPoint_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.ResetAppPoint = temp;
            Utility.SaveConfig(config);
        }

        private void btResetPoint1_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.ResetPoint1 = temp;
            Utility.SaveConfig(config);
        }

        private void btResetAppPoint2_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.ResetPoint2 = temp;
            Utility.SaveConfig(config);
        }

        private void btResetAppPoint3_Click(object sender, EventArgs e)
        {
            NewConfig config = Utility.LoadConfig(false);
            Point temp = new Point(int.Parse(txtVNCPointX.Text), int.Parse(txtVNCPointY.Text));
            config.ResetPoint3 = temp;
            Utility.SaveConfig(config);
        }

      
        #endregion

        private void ListIPCopy_Click(object sender, EventArgs e)
        {
            BindingList<VNC> listVNC = new BindingList<VNC>();
            string[] listStr = txtListIP.Text.Split('\n');

            foreach (string item in listStr)
            {
                string str = item.Replace(System.Environment.NewLine, "");
                VNC v = new VNC();
                v.IP = NewConfig.Config.DefaultIP + str;
                listVNC.Add(v);
            }
            Utility.SaveListVNC(listVNC);
            LoadFirst();
        }
    }
}