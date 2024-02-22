using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;
using DataClassLibrary2024;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataFromFile DFF { get; set; } = new DataFromFile();

        private void button1_Click(object sender, EventArgs e)
        {
            DFF.SelectFile();
        }
    }
}
