using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatchAndUI
{
    public partial class Form1 : Form
    {
        private IniOk iniOk;
        private IniNg iniNg;

        public Form1()
        {
            InitializeComponent();
            iniOk = new IniOk();
            iniOk.OnIniEvent += IniGo_OnIniEvent;

            iniNg = new IniNg();
            iniNg.OnIniEvent += IniGo_OnIniEvent;
        }

        private void IniGo_OnIniEvent(object sender, IniEventArgs e)
        {

            if (e.IsOk)
            {
                var timeStamp = DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]");
                var msg = timeStamp + e.ItemName + "初始化完成\n";
                ListBoxAppend(listBox1, msg);
                //if (e.ItemName == "全部")
                //{
                //    GoNextForm();
                //}
            }
            else
            {
                var timeStamp = DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]");
                var msg = timeStamp + e.ItemName + "初始化失敗\n";
                ListBoxAppend(listBox1, msg);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            iniOk.GoIni();
        }

        public delegate void ListBoxAppendCallback(ListBox listBox, string msg);
        private void ListBoxAppend(ListBox listBox, string msg)
        {
            if (listBox.InvokeRequired)
            {
                ListBoxAppendCallback mydel = new ListBoxAppendCallback(ListBoxAppend);
                this.Invoke(mydel, new object[] { listBox, msg });
            }
            else
            {
                listBox.Items.Add(msg);
            }
        }

        private void btnNg_Click(object sender, EventArgs e)
        {
            iniNg.GoIni();
        }
    }
}
