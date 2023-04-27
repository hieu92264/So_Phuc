namespace So_Phuc
{
    public partial class Form1 : Form
    {
        bool isAdd = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdo_add.Checked = isAdd;
        }

        private void rdo_add_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_sub_CheckedChanged(object sender, EventArgs e)
        {
            isAdd = false;
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai rồi!");
            }
            if ((e.KeyChar == '+') || (e.KeyChar == '-'))
            {
                if (txt_a.SelectionStart != 0) // Kiểm tra vị trí con trỏ
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
                else if (txt_a.Text.Contains("+") || txt_a.Text.Contains("-")) // Kiểm tra dấu '+' hoặc '-' đã tồn tại trong TextBox
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
            }
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai rồi!");
            }
            if ((e.KeyChar == '+') || (e.KeyChar == '-'))
            {
                if (txt_b.SelectionStart != 0) // Kiểm tra vị trí con trỏ
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
                else if (txt_b.Text.Contains("+") || txt_b.Text.Contains("-")) // Kiểm tra dấu '+' hoặc '-' đã tồn tại trong TextBox
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
            }
        }

        private void txt_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai rồi!");
            }
            if ((e.KeyChar == '+') || (e.KeyChar == '-'))
            {
                if (txt_c.SelectionStart != 0) // Kiểm tra vị trí con trỏ
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
                else if (txt_c.Text.Contains("+") || txt_c.Text.Contains("-")) // Kiểm tra dấu '+' hoặc '-' đã tồn tại trong TextBox
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
            }
        }

        private void txt_d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai rồi!");
            }
            if ((e.KeyChar == '+') || (e.KeyChar == '-'))
            {
                if (txt_a.SelectionStart != 0) // Kiểm tra vị trí con trỏ
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
                else if (txt_d.Text.Contains("+") || txt_d.Text.Contains("-")) // Kiểm tra dấu '+' hoặc '-' đã tồn tại trong TextBox
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
            }
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            txt_d.Clear();
            rdo_add.Checked = true;
            txt_e.Clear();
            txt_f.Clear();
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt_a.Text);
                int b = Convert.ToInt32(txt_b.Text);
                int c = Convert.ToInt32(txt_c.Text);
                int d = Convert.ToInt32(txt_d.Text);
                ComplexNumber CN = new ComplexNumber(a, b);
                int[] s;
                if (isAdd)
                {
                    s = CN.add(c, d);
                    txt_e.Text = s[0].ToString();
                    txt_f.Text = s[1].ToString();

                }
                else
                {
                    s = CN.sub(c, d);
                    txt_e.Text = s[0].ToString();
                    txt_f.Text = s[1].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Application.Exit();
        }
    }
}