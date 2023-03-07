using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class AddKeyword : Form
    {
        public AddKeyword()
        {
            InitializeComponent();
        }
        public string getInputText()
        {
            return txtKeyword.Text;
        }

        
    }
}
