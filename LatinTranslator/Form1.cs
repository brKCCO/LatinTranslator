using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class latinTranslator : Form
    {
        public latinTranslator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Left";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Right";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Center";
        }

        private void latinTranslator_Load(object sender, EventArgs e)
        {

        }

    }
}
