using System.Windows.Forms;

namespace Requirement_2
{
    partial class MainForm
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
            btn_min = new AntdUI.Button();
            btn_max = new AntdUI.Button();
            btn_close = new AntdUI.Button();
            input_student_number = new AntdUI.Input();
            input_name = new AntdUI.Input();
            input_gender = new AntdUI.Input();
            input_age = new AntdUI.Input();
            input_specialized = new AntdUI.Input();
            panel_top = new Panel();
            label = new AntdUI.Label();
            confirm = new AntdUI.Button();
            panel_top.SuspendLayout();
            SuspendLayout();
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
            btn_min.Location = new Point(342, 0);
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
            btn_max.Location = new Point(392, 0);
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
            btn_close.Location = new Point(442, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(58, 40);
            btn_close.TabIndex = 1;
            btn_close.Click += Btn_close_Click;
            // 
            // input_student_number
            // 
            input_student_number.Location = new Point(100, 81);
            input_student_number.Name = "input_student_number";
            input_student_number.PlaceholderText = "学号";
            input_student_number.Size = new Size(300, 50);
            input_student_number.TabIndex = 1;
            input_student_number.TextChanged += Input_Student_Number_TextChanged;
            // 
            // input_name
            // 
            input_name.Location = new Point(100, 131);
            input_name.Name = "input_name";
            input_name.PlaceholderText = "姓名";
            input_name.Size = new Size(300, 50);
            input_name.TabIndex = 2;
            input_name.TextChanged += Input_Student_Name_TextChanged;
            // 
            // input_gender
            // 
            input_gender.Location = new Point(100, 181);
            input_gender.Name = "input_gender";
            input_gender.PlaceholderText = "性别";
            input_gender.Size = new Size(300, 50);
            input_gender.TabIndex = 3;
            input_gender.TextChanged += Input_Gender_TextChanged;
            // 
            // input_age
            // 
            input_age.Location = new Point(100, 231);
            input_age.Name = "input_age";
            input_age.PlaceholderText = "年龄";
            input_age.Size = new Size(300, 50);
            input_age.TabIndex = 4;
            input_age.TextChanged += Input_Age_TextChanged;
            // 
            // input_specialized
            // 
            input_specialized.Location = new Point(100, 281);
            input_specialized.Name = "input_specialized";
            input_specialized.PlaceholderText = "专业";
            input_specialized.Size = new Size(300, 50);
            input_specialized.TabIndex = 5;
            input_specialized.TextChanged += Input_Specialized_TextChanged;
            // 
            // panel_top
            // 
            panel_top.Controls.Add(label);
            panel_top.Controls.Add(btn_min);
            panel_top.Controls.Add(btn_max);
            panel_top.Controls.Add(btn_close);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(500, 40);
            panel_top.TabIndex = 0;
            // 
            // label
            // 
            label.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label.Location = new Point(12, 0);
            label.Name = "label";
            label.Size = new Size(138, 40);
            label.TabIndex = 4;
            label.Text = "学生信息收集工具";
            // 
            // confirm
            // 
            confirm.BorderWidth = 1F;
            confirm.Location = new Point(100, 331);
            confirm.Name = "confirm";
            confirm.Size = new Size(300, 50);
            confirm.TabIndex = 0;
            confirm.Text = "确定";
            confirm.Click += Confirm_Click;
            // 
            // MainForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(500, 406);
            Controls.Add(confirm);
            Controls.Add(panel_top);
            Controls.Add(input_student_number);
            Controls.Add(input_name);
            Controls.Add(input_gender);
            Controls.Add(input_age);
            Controls.Add(input_specialized);
            Font = new Font("Microsoft YaHei UI Light", 12F);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(500, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Input_name_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private AntdUI.Button btn_close;
        private AntdUI.Button btn_min;
        private AntdUI.Button btn_max;
        private AntdUI.Input input_student_number;
        private AntdUI.Input input_name;
        private AntdUI.Input input_gender;
        private AntdUI.Input input_age;
        private AntdUI.Input input_specialized;
        private Panel panel_top;
        private AntdUI.Button confirm;
        private AntdUI.Label label;
    }
}
