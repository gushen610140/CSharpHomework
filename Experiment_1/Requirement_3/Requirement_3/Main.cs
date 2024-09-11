using System.Diagnostics;

namespace Requirement_3
{
    public partial class Main : AntdUI.Window
    {
        public Main()
        {
            InitializeComponent();

            title.MouseDown += Window_MouseDown;
            panel_top.MouseDown += Window_MouseDown;
        }

        void Window_MouseDown(object? sender, MouseEventArgs e)
        {
            DraggableMouseDown();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            DraggableMouseDown();
            base.OnMouseDown(e);
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            Min();
        }

        private void Btn_max_Click(object sender, EventArgs e)
        {
            MaxRestore();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            expression.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expression.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expression.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expression.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expression.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expression.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expression.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expression.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expression.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expression.Text += "9";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            expression.Text += "+";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            expression.Text += ".";
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            expression.Text += "-";
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            expression.Text += "*";
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            expression.Text += "/";
        }

        private void button_lock_Click(object sender, EventArgs e)
        {
            expression.Text = "";
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            Utils.SolveInfixExpression solver = new(expression.Text);
            try
            {
                expression.Text = solver.Solve();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                expression.Text = "Error";
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            expression.Text += "(";
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            expression.Text += ")";
        }

        private void button_sqaure_Click(object sender, EventArgs e)
        {
            expression.Text += "^";
        }
    }
}
