using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public string FIO { get; set; } = "Alex";
        [DisplayName("Базовый цвет")]
        [Description("Базовый цвет"), Category("Цвет")]
        public Color Color1 { get; set; } = Color.Red;
        [DisplayName("Второй цвет")]
        [Description("Второй цвет"), Category("Цвет")]
        public Color Color2 { get; set; } = Color.Blue;
    }
}
