using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH09_NicholasFelix
{
    public partial class FormImage : Form
    {
        string category;

        string itemname1;
        string itemname2;
        string itemname3;

        int itemcost1;
        int itemcost2;
        int itemcost3;
        public FormImage(string category)
        {
            InitializeComponent();
            this.category = category;
            GenerateImg();
        }

        public FormShop Foorm 
        { 
            get; 
            set; 
        }
        private void GenerateImg()
        {
            if (category == "tshirt")
            {
                pictureBox1.Image = Properties.Resources.ts1;
                pictureBox2.Image = Properties.Resources.ts2;
                pictureBox3.Image = Properties.Resources.ts3;

                name1.Text = "Weeb TShirt 1";
                cost1.Text = "Rp. 90.000";
                itemname1 = "Weeb Shirt 1";
                itemcost1 = 90000;

                name2.Text = "Weeb TShirt 2";
                cost2.Text = "Rp. 80.000";
                itemname2 = "Weeb TShirt 2";
                itemcost2 = 80000;

                name3.Text = "Weeb TShirt 3";
                cost3.Text = "Rp. 70.000";
                itemname3 = "Weeb TShirt 3";
                itemcost3 = 70000;
            }
            else if (category == "shirt")
            {
                pictureBox1.Image = Properties.Resources.s1;
                pictureBox2.Image = Properties.Resources.s2;
                pictureBox3.Image = Properties.Resources.s3;

                name1.Text = "Weeb Shirt Hmm";
                cost1.Text = "Rp. 95.000";
                itemname1 = "Weeb Shirt Hmm";
                itemcost1 = 95000;

                name2.Text = "Weeb Shirt EZ";
                cost2.Text = "Rp. 85.000";
                itemname2 = "Weeb Shirt EZ";
                itemcost2 = 85000;

                name3.Text = "Weeb Shirt A";
                cost3.Text = "Rp. 75.000";
                itemname3 = "Weeb Shirt A";
                itemcost3 = 75000;
            }
            else if (category == "pant")
            {
                pictureBox1.Image = Properties.Resources.p1;
                pictureBox2.Image = Properties.Resources.p2;
                pictureBox3.Image = Properties.Resources.p3;

                name1.Text = "Weeb Pants 1";
                cost1.Text = "Rp. 115.000";
                itemname1 = "Weeb Pants 1";
                itemcost1 = 115000;

                name2.Text = "Weeb Pants GG";
                cost2.Text = "Rp. 125.000";
                itemname2 = "Weeb Pants GG";
                itemcost2 = 125000;

                name3.Text = "Weeb Pants H";
                cost3.Text = "Rp. 135.000";
                itemname3 = "Weeb Pants H";
                itemcost3 = 135000;
            }
            else if (category == "longpant")
            {
                pictureBox1.Image = Properties.Resources.lp1;
                pictureBox2.Image = Properties.Resources.lp2;
                pictureBox3.Image = Properties.Resources.lp3;

                name1.Text = "Weeb Long Pants 0";
                cost1.Text = "Rp. 115.000";
                itemname1 = "Weeb Long Pants 0";
                itemcost1 = 115000;

                name2.Text = "Weeb Long Pants Xo";
                cost2.Text = "Rp. 125.000";
                itemname2 = "Weeb Long Pants Xo";
                itemcost2 = 125000;

                name3.Text = "Weeb Long Pants Xl";
                cost3.Text = "Rp. 135.000";
                itemname3 = "Weeb Long Pants Xl";
                itemcost3 = 135000;
            }
            else if (category == "sho")
            {
                pictureBox1.Image = Properties.Resources.ss1;
                pictureBox2.Image = Properties.Resources.ss2;
                pictureBox3.Image = Properties.Resources.ss3;

                name1.Text = "Shoes o Shoes";
                cost1.Text = "Rp. 315.000";
                itemname1 = "Shoes o Shoes";
                itemcost1 = 315000;

                name2.Text = "Shooooes";
                cost2.Text = "Rp. 325.000";
                itemname2 = "Shooooes";
                itemcost2 = 325000;

                name3.Text = "Shes";
                cost3.Text = "Rp. 335.000";
                itemname3 = "Shes";
                itemcost3 = 335000;
            }
            else if (category == "jew")
            {
                pictureBox1.Image = Properties.Resources.j1;
                pictureBox2.Image = Properties.Resources.j2;
                pictureBox3.Image = Properties.Resources.j3;

                name1.Text = "Moon Thing";
                cost1.Text = "Rp. 515.000";
                itemname1 = "Moon Thing";
                itemcost1 = 515000;

                name2.Text = "Neck a Lace";
                cost2.Text = "Rp. 525.000";
                itemname2 = "Neck a Lace";
                itemcost2 = 525000;

                name3.Text = "I Dunno, im stoopid";
                cost3.Text = "Rp. 635.000";
                itemname3 = "I Dunno, im stoopid";
                itemcost3 = 635000;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Foorm.CartingHome(itemname1, itemcost1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Foorm.CartingHome(itemname2, itemcost2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Foorm.CartingHome(itemname3, itemcost3);
        }
    }
}
