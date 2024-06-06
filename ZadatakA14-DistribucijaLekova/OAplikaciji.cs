using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakA14_DistribucijaLekova
{
    public partial class OAplikaciji : Form
    {
        public OAplikaciji()
        {
            InitializeComponent();
        }

        private void OAplikaciji_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\Skola\MATURA\Programiranje\ZadatakA14-DistribucijaLekova\A14.rtf");
        }
    }
}
