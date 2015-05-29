using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = MinimumSize = Size;
            EnableOkButtonOrDis();
            if(CurrentProxyStatue())
            Load_proxy();

        }
        public string TrimProxyString(string defp)
        {

            if (defp[defp.Length - 1] == '/')
                defp = defp.Substring(0, defp.Length - 1);
             bool passedfirstdot = false;
            string org_prox = "";
            foreach (char c in defp)
            {
                if (passedfirstdot && c != '/')
                {
                    org_prox += c.ToString();
                }
                else if (c == '/' || (c >= '0' && c <= '9'))
                    passedfirstdot = true;
            }
            if (org_prox.Contains(":") == false)
                return defp;
            return org_prox;    
        }
        private void Load_proxy()
        {
            try
            {
                string prox_str = GetCurrentProxyString();
                string org_prox = TrimProxyString(prox_str);
                rb_Custom.Checked = true;

              string[] splidbycolon = org_prox.Split(new char[] { ':' });
                txbxIp.Text = splidbycolon[0];
                NmPort.Value = decimal.Parse(splidbycolon[1]);

            }
            catch
            {
                MessageBox.Show("Could not load current proxy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txbxIp_TextChanged(object sender, EventArgs e)
        {
            EnableOkButtonOrDis();
            lblChange.Text = "...";
        }

        private void EnableOkButtonOrDis()
        {
              btnOk.Enabled = (RbNone.Checked)?true:Regex.Match(txbxIp.Text, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Success;
            
        }

        private void rb_Custom_CheckedChanged(object sender, EventArgs e)
        {
            EnableOkButtonOrDis();
            txbxIp.Enabled = NmPort.Enabled = rb_Custom.Checked;
        }

        private void RbNone_CheckedChanged(object sender, EventArgs e)
        {
            EnableOkButtonOrDis();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (RbNone.Checked)
                    ProxyHandler.setProxy("", false);
                else
                    ProxyHandler.setProxy(txbxIp.Text + ":" + NmPort.Value.ToString(), true);
                lblChange.Text=("Changed");
            }
            catch (Exception ss) { MessageBox.Show(ss.Message, "Error"); lblChange.Text = ("Error"); }
            CurrentProxyStatue();


            //this.WindowState = FormWindowState.Minimized;
        }

         
         public void Notify(string tex , string title="Mister Proxer" , int v =500)
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = tex;
            notifyIcon1.ShowBalloonTip(v);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CurrentProxyStatue();
        }

        private bool CurrentProxyStatue()
        {
               HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            // Obtain the 'Proxy' of the  Default browser.  
            IWebProxy proxy = myWebRequest.Proxy;
            // Print the Proxy Url to the console.
            if (proxy != null)
            {
                string prx = TrimProxyString(proxy.GetProxy(myWebRequest.RequestUri).ToString());
                string res = string.Format("Proxy: {0}", prx);
                lblCPS.Text ="Current  "+res;
                if (res.Contains("micro"))
                {
                    lblCPS.Text = "No proxy";
                    Notify(lblCPS.Text);

                    return false;
                }
                Notify(lblCPS.Text);
                return true;

            }
            else
            {
                lblCPS.Text="No proxy";
                Notify(lblCPS.Text);
                return false;
            } 
        }

        private string  GetCurrentProxyString()
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            // Obtain the 'Proxy' of the  Default browser.  
            IWebProxy proxy = myWebRequest.Proxy;
            // Print the Proxy Url to the console.
            if (proxy != null)
            {
                string res = proxy.GetProxy(myWebRequest.RequestUri).ToString();//string.Format("Proxy: {0}", );
                if (res.Contains("micro"))
                    return "No proxy";
                else return res;
            }
            else
            {
                return  "No proxy";
            }
        }

        private void lblChange_TextChanged(object sender, EventArgs e)
        {
            lblChange.ForeColor=(lblChange.Text.Contains("changed")==false)?Color.LimeGreen:Color.Red;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Mister Proxer ";
            notifyIcon1.BalloonTipText = "Im here "+Environment.UserName;

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
               if(checkBox_Silence.Checked==false)
                   notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void linkLabelhint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This option allows you to show or hide notification messages ","Hint",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/yassergersy");
        }

        private void SetAndMinimize(object sender, EventArgs e)
        {
            btnOk_Click( sender,  e);
            this.WindowState = FormWindowState.Minimized;

        }
    }
    class ProxyHandler
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;


        public static void setProxy(string proxyhost, bool proxyEnabled)
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            const string keyName = userRoot + "\\" + subkey;

            Registry.SetValue(keyName, "ProxyServer", proxyhost);
            Registry.SetValue(keyName, "ProxyEnable", proxyEnabled ? "1" : "0");

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

    }

}
