using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        [DisplayName("Базовый цвет")]
        [Description("Базовый цвет"), Category("Цвет")]
        public Color Color1 { get; set; } = Color.Red;
        [DisplayName("Второй цвет")]
        [Description("Второй цвет"), Category("Цвет")]
        public Color Color2 { get; set; } = Color.Blue;

        private void UserControl1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == this.Color1)
            {
                this.BackColor = this.Color2;
            }
            else
            {
                this.BackColor = this.Color1;
            }
        }
    }
}
