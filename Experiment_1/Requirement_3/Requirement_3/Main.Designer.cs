namespace Requirement_3
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_top = new Panel();
            title = new AntdUI.Label();
            btn_min = new AntdUI.Button();
            btn_max = new AntdUI.Button();
            btn_close = new AntdUI.Button();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            button4 = new AntdUI.Button();
            button5 = new AntdUI.Button();
            button6 = new AntdUI.Button();
            button7 = new AntdUI.Button();
            button8 = new AntdUI.Button();
            button9 = new AntdUI.Button();
            button_dot = new AntdUI.Button();
            button0 = new AntdUI.Button();
            button_add = new AntdUI.Button();
            button_enter = new AntdUI.Button();
            button_lock = new AntdUI.Button();
            button_div = new AntdUI.Button();
            button_mul = new AntdUI.Button();
            button_sub = new AntdUI.Button();
            expression = new AntdUI.Label();
            button_sqaure = new AntdUI.Button();
            button_right = new AntdUI.Button();
            button_left = new AntdUI.Button();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.Controls.Add(title);
            panel_top.Controls.Add(btn_min);
            panel_top.Controls.Add(btn_max);
            panel_top.Controls.Add(btn_close);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(300, 40);
            panel_top.TabIndex = 0;
            // 
            // title
            // 
            title.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            title.Location = new Point(12, 0);
            title.Name = "title";
            title.Size = new Size(68, 40);
            title.TabIndex = 4;
            title.Text = "计算器";
            // 
            // btn_min
            // 
            btn_min.BackActive = Color.FromArgb(172, 172, 172);
            btn_min.BackColor = Color.Transparent;
            btn_min.BackHover = Color.FromArgb(223, 223, 223);
            btn_min.Dock = DockStyle.Right;
            btn_min.Font = new Font("Microsoft YaHei UI Light", 18F);
            btn_min.Ghost = true;
            btn_min.Icon = Properties.Resources.app_minb;
            btn_min.Location = new Point(142, 0);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(50, 40);
            btn_min.TabIndex = 3;
            btn_min.Click += Btn_min_Click;
            // 
            // btn_max
            // 
            btn_max.BackActive = Color.FromArgb(172, 172, 172);
            btn_max.BackColor = Color.Transparent;
            btn_max.BackHover = Color.FromArgb(223, 223, 223);
            btn_max.Dock = DockStyle.Right;
            btn_max.Font = new Font("Microsoft YaHei UI Light", 18F);
            btn_max.Ghost = true;
            btn_max.Icon = Properties.Resources.app_maxb;
            btn_max.Location = new Point(192, 0);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(50, 40);
            btn_max.TabIndex = 2;
            btn_max.Click += Btn_max_Click;
            // 
            // btn_close
            // 
            btn_close.BackActive = Color.FromArgb(145, 31, 20);
            btn_close.BackColor = Color.Transparent;
            btn_close.BackHover = Color.FromArgb(196, 43, 28);
            btn_close.Dock = DockStyle.Right;
            btn_close.Font = new Font("Microsoft YaHei UI Light", 20F);
            btn_close.Ghost = true;
            btn_close.Icon = Properties.Resources.app_closeb;
            btn_close.Location = new Point(242, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(58, 40);
            btn_close.TabIndex = 1;
            btn_close.Click += Btn_close_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 447);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(86, 447);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(152, 447);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 381);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(86, 381);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(152, 381);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(20, 315);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(86, 315);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(152, 315);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.Click += button9_Click;
            // 
            // button_dot
            // 
            button_dot.Location = new Point(152, 513);
            button_dot.Name = "button_dot";
            button_dot.Size = new Size(60, 60);
            button_dot.TabIndex = 15;
            button_dot.Text = ".";
            button_dot.Click += button_dot_Click;
            // 
            // button0
            // 
            button0.Location = new Point(20, 513);
            button0.Name = "button0";
            button0.Size = new Size(126, 60);
            button0.TabIndex = 14;
            button0.Text = "0";
            button0.Click += button0_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(218, 249);
            button_add.Name = "button_add";
            button_add.Size = new Size(60, 126);
            button_add.TabIndex = 16;
            button_add.Text = "+";
            button_add.Click += button_add_Click;
            // 
            // button_enter
            // 
            button_enter.Location = new Point(218, 381);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(60, 192);
            button_enter.TabIndex = 17;
            button_enter.Text = "enter";
            button_enter.Click += button_enter_Click;
            // 
            // button_lock
            // 
            button_lock.Location = new Point(20, 183);
            button_lock.Name = "button_lock";
            button_lock.Size = new Size(60, 60);
            button_lock.TabIndex = 18;
            button_lock.Text = "Clear";
            button_lock.Click += button_lock_Click;
            // 
            // button_div
            // 
            button_div.Location = new Point(86, 183);
            button_div.Name = "button_div";
            button_div.Size = new Size(60, 60);
            button_div.TabIndex = 19;
            button_div.Text = "/";
            button_div.Click += button_div_Click;
            // 
            // button_mul
            // 
            button_mul.Location = new Point(152, 183);
            button_mul.Name = "button_mul";
            button_mul.Size = new Size(60, 60);
            button_mul.TabIndex = 20;
            button_mul.Text = "*";
            button_mul.Click += button_mul_Click;
            // 
            // button_sub
            // 
            button_sub.Location = new Point(218, 183);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(60, 60);
            button_sub.TabIndex = 21;
            button_sub.Text = "-";
            button_sub.Click += button_sub_Click;
            // 
            // expression
            // 
            expression.BackColor = SystemColors.ControlLight;
            expression.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            expression.Location = new Point(20, 74);
            expression.Name = "expression";
            expression.Padding = new Padding(10, 0, 10, 0);
            expression.Size = new Size(258, 74);
            expression.TabIndex = 22;
            expression.Text = "";
            // 
            // button_sqaure
            // 
            button_sqaure.Location = new Point(152, 249);
            button_sqaure.Name = "button_sqaure";
            button_sqaure.Size = new Size(60, 60);
            button_sqaure.TabIndex = 25;
            button_sqaure.Text = "^";
            button_sqaure.Click += button_sqaure_Click;
            // 
            // button_right
            // 
            button_right.Location = new Point(86, 249);
            button_right.Name = "button_right";
            button_right.Size = new Size(60, 60);
            button_right.TabIndex = 24;
            button_right.Text = ")";
            button_right.Click += button_right_Click;
            // 
            // button_left
            // 
            button_left.Location = new Point(20, 249);
            button_left.Name = "button_left";
            button_left.Size = new Size(60, 60);
            button_left.TabIndex = 23;
            button_left.Text = "(";
            button_left.Click += button_left_Click;
            // 
            // Main
            // 
            ClientSize = new Size(300, 600);
            Controls.Add(button_sqaure);
            Controls.Add(button_right);
            Controls.Add(button_left);
            Controls.Add(expression);
            Controls.Add(button_sub);
            Controls.Add(button_mul);
            Controls.Add(button_div);
            Controls.Add(button_lock);
            Controls.Add(button_enter);
            Controls.Add(button_add);
            Controls.Add(button_dot);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel_top);
            MinimumSize = new Size(300, 600);
            Name = "Main";
            panel_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private AntdUI.Label title;
        private AntdUI.Button btn_close;
        private AntdUI.Button btn_min;
        private AntdUI.Button btn_max;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Button button4;
        private AntdUI.Button button5;
        private AntdUI.Button button6;
        private AntdUI.Button button7;
        private AntdUI.Button button8;
        private AntdUI.Button button9;
        private AntdUI.Button button_dot;
        private AntdUI.Button button0;
        private AntdUI.Button button_add;
        private AntdUI.Button button_enter;
        private AntdUI.Button button_lock;
        private AntdUI.Button button_div;
        private AntdUI.Button button_mul;
        private AntdUI.Button button_sub;
        private AntdUI.Label expression;
        private AntdUI.Button button_sqaure;
        private AntdUI.Button button_right;
        private AntdUI.Button button_left;
    }
}
