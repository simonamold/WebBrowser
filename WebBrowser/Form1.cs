using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        private SQLiteConnection conn = null;
        List<string> blockedKwds;

        public Form1()
        {
            InitializeComponent();
            FileStream f = new FileStream("BrowserLog.txt", FileMode.OpenOrCreate);
            TextWriterTraceListener txtTrace = new TextWriterTraceListener(f);
            Trace.Listeners.Add(txtTrace);
        }
        private async Task<bool> AsyncCheckBlocked(string url)
        {
            bool result = await Task.Run(
                async () =>
                {
                    return (from x in blockedKwds
                            where url.Contains(x)
                            select x).Count() > 0;
                }
            );
            return result;
        }

        private async Task<int> AsyncWriteTrace(string msg)
        {
            int result = await Task.Run(
                async () =>
                {
                    Trace.WriteLine(msg + " " + DateTime.Now.ToString("dd-MM-yyyy h:mm:ss"));
                    Trace.Flush();
                    return 0;
                }
                );
            return result;
        }

        // scriere in fiseir actiune + data/ora
        private void LogWrite(string msg)
        {
            var res = Task.Run(() => AsyncWriteTrace(msg));
            res.Wait();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                webBrowser.Navigate(txtUrl.Text);
                txtUrl.Clear();
            }
            else
                MessageBox.Show("Empty field!");

            LogWrite("Go button pressed: ");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!webBrowser.GoBack())
                MessageBox.Show("No previous page available");

            LogWrite("Back button pressed: ");
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();

            LogWrite("Forward button pressed: ");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();

            LogWrite("Home button pressed: ");
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser.Navigate(txtUrl.Text);
                txtUrl.Clear();

                LogWrite("Enter pressed for navigation: ");
            }
        }

        private void tsConnect_Click(object sender, EventArgs e)
        {
            conn = SQLiteHandler.ConnectToDB();
            if(conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connected!");
            }
            blockedKwds = SQLiteHandler.GetAllKeyWords(conn);

            LogWrite("Connect button pressed: ");
        }

        private void tsAddKeyword_Click(object sender, EventArgs e)
        {
            if (conn.State == System.Data.ConnectionState.Closed )
            {
                MessageBox.Show("No database connection!");
            }
            else
            {
                AddKeyword kwdForm = new AddKeyword();
                if (kwdForm.ShowDialog() == DialogResult.OK)
                {
                    string kwd = kwdForm.getInputText();
                    if (!string.IsNullOrEmpty(kwd))
                    {
                        SQLiteHandler.InsertKeyword(conn, kwd);
                    }
                    else
                        MessageBox.Show("No keyword introduced!");
                }
            }
            blockedKwds= SQLiteHandler.GetAllKeyWords(conn);

            LogWrite("Add Keyword button pressed: ");
        }
        
        private void tsDisconnect_Click(object sender, EventArgs e)
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("No database connection");
            }
            else 
            {
                blockedKwds = SQLiteHandler.GetAllKeyWords(conn);
                SQLiteHandler.DisconnectFromDB(conn);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    MessageBox.Show("Disconnected!");
                }
            }

            LogWrite("Disconnect button pressed: ");
        }

        private void tsViewKeyword_Click(object sender, EventArgs e)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("No connection to database!");
            }
            else
            {
                tsComboBox.Items.Clear();
                blockedKwds = SQLiteHandler.GetAllKeyWords(conn);
                if (blockedKwds != null)
                {
                    foreach (string kwd in blockedKwds)
                    {
                        tsComboBox.Items.Add(kwd);
                    }
                }
            }

            LogWrite("View Keyword button pressed: ");
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("No connection to database!");
            }
            else
            {
                AddKeyword kwdForm = new AddKeyword();
                if (kwdForm.ShowDialog() == DialogResult.OK)
                {
                    string kwd = kwdForm.getInputText();
                    if (string.IsNullOrEmpty(kwd))
                        MessageBox.Show("No keyword introduced!");
                    else
                    {
                        SQLiteHandler.RemoveKeyword(conn, kwd);
                    }
                }
            }
            blockedKwds = SQLiteHandler.GetAllKeyWords(conn);

            LogWrite("Remove Keyword Button pressed: ");
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string url = e.Url.ToString();
            var result = Task.Run(() => AsyncCheckBlocked(url));
            result.Wait();
            if (result.Result)
            {
                e.Cancel = true;
                MessageBox.Show("Blocked Url");
            }
        }

        private void tsComboBox_Click(object sender, EventArgs e)
        {
            tsComboBox.Items.Clear();
            if (blockedKwds != null)
            {
                foreach (string kwd in blockedKwds)
                {
                    tsComboBox.Items.Add(kwd);
                }
            }
        }

        // incarca lista de cuv blocate la deschiderea ferestrei
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = SQLiteHandler.ConnectToDB();
            blockedKwds = SQLiteHandler.GetAllKeyWords(conn);
            SQLiteHandler.DisconnectFromDB(conn);

            LogWrite("Main Window Load: ");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm img = new AboutForm();
            img.ShowDialog();

            LogWrite("About button pressed: ");
        }
    }
}
