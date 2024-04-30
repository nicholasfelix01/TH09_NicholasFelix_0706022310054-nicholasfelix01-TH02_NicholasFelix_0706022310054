using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TH09_NicholasFelix
{
    public partial class FormCustomOrder : Form
    {
        public FormShop Form
        {
            get;
            set;
        }
        public FormCustomOrder()
        {
            InitializeComponent();
            HiandBye(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string derp = "";
            OpenFileDialog TheD = new OpenFileDialog();
            TheD.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (TheD.ShowDialog() == DialogResult.OK)
            {
                derp = TheD.FileName;
                pictureBox2.ImageLocation = derp;
                HiandBye(true);
            }
        }

        private void HiandBye(bool YesNoMaybe)
        {
            textBox1.Enabled = YesNoMaybe;
            textBox2.Enabled = YesNoMaybe;
            button1.Enabled = YesNoMaybe;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            HiandBye(false);
            textBox1.Text = "";
            textBox2.Text = "";
            pictureBox2.Image = null;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{Form.CartingHome(textBox1.Text, int.Parse(textBox2.Text.ToString()));}
            catch{/*Nothing*/}
        }
    }
    
}







