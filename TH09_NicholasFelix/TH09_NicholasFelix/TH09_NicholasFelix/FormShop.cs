using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TH09_NicholasFelix
{
    public partial class FormShop : Form
    {
        DataTable everything = new DataTable();
        public FormShop()
        {
            InitializeComponent();
            dosomething();
            
            
        }
        public void dosomething()
        {
            everything.Columns.Add("Item Name");
            everything.Columns.Add("Quantity");
            everything.Columns.Add("Price");
            everything.Columns.Add("Total");
            dgv.DataSource = everything;
            dgv.ReadOnly = true;
            lbl_1.ReadOnly = true;
            lbl_2.ReadOnly = true;
            lbl_3.ReadOnly = true;
        }

        public void reset()
        {
            int st = 0;
            for (int i = 0; i < everything.Rows.Count; i++)
            {
                st += Convert.ToInt32(everything.Rows[i][3].ToString());
            }
            lbl_1.Text = st.ToString();
            lbl_3.Text = (st + (st / 10)).ToString();
            lbl_2.Text = (st / 10).ToString();
        }

        public void CartingHome(string item, int cost)
        {
            int awdawdawdw = 1;
            int qtyinhere = 9;
            for (int i = 0; i < everything.Rows.Count; i++)
            {
                qtyinhere = 0;
                if (everything.Rows[i][0].ToString() == item)
                {
                    qtyinhere = int.Parse(everything.Rows[i][1].ToString());
                    everything.Rows[i][1] = qtyinhere + 1;
                    everything.Rows[i][3] = qtyinhere * cost;
                    awdawdawdw = 69;
                    break;
                }
            }
            if (awdawdawdw == 1)
            {
                everything.Rows.Add(item, 1, cost, cost);
            }

            reset();
        }

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_show.Controls.Clear();
            FormImage form = new FormImage("tshirt");
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            form.Foorm = this;
            pnl_show.Controls.Add(form);
            form.Show();
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_show.Controls.Clear();
            FormImage form = new FormImage("shirt");
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            form.Foorm = this;
            pnl_show.Controls.Add(form);
            form.Show();
        }

        private void pantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_show.Controls.Clear();
            FormImage form = new FormImage("pant");
            form.Dock = DockStyle.Top;
            form.Foorm = this;
            form.TopLevel = false;
            pnl_show.Controls.Add(form);
            form.Show();
        }

        private void longPantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_show.Controls.Clear();
            FormImage form = new FormImage("longpant");
            form.Foorm = this;
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            pnl_show.Controls.Add(form);
            form.Show();
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_show.Controls.Clear();
            FormImage form = new FormImage("sho");
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            form.Foorm = this;
            pnl_show.Controls.Add(form);
            form.Show();
        }

        private void jewelryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_show.Controls.Clear();
            FormImage form = new FormImage("jew");
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            form.Foorm = this;
            pnl_show.Controls.Add(form);
            form.Show();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_show.Controls.Clear();
            FormCustomOrder form = new FormCustomOrder();
            form.Dock = DockStyle.Top;
            form.Form = this;
            form.TopLevel = false;
            pnl_show.Controls.Add(form);
            form.Show();
        }

        private void btnDIe_Click(object sender, EventArgs e)
        {
            int thing = 0;

            if (everything.Rows.Count > 0)
            {everything.Rows[dgv.CurrentCell.RowIndex].Delete();}
            for (int i = 0; i < everything.Rows.Count; i++)
            {thing += Convert.ToInt32(everything.Rows[i][3].ToString());}

            lbl_1.Text = thing.ToString();
            lbl_3.Text = (thing + (thing / 10)).ToString();
            lbl_2.Text = (thing / 10).ToString();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && everything.Rows.Count > 0)
            {
                everything.Rows[dgv.CurrentCell.RowIndex].Delete();
            }
            reset();
        }
    }
}