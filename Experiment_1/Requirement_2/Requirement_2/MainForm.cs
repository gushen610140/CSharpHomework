using System.Diagnostics;

namespace Requirement_2
{
    // 使用 partial 关键字，该类将可以由多个类定义合成
    public partial class MainForm : AntdUI.Window
    {

        private string StudentNumber { get; set; } = "";
        private string StudentName { get; set; } = "";
        private string Gender { get; set; } = "";
        private string Age { get; set; } = "";
        private string Specialized { get; set; } = "";

        public MainForm()
        {
            InitializeComponent();

            panel_top.MouseDown += Window_MouseDown;
            label.MouseDown += Window_MouseDown;
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

        private void Input_Student_Number_TextChanged(object sender, EventArgs e)
        {
            StudentNumber = input_student_number.Text;
        }

        private void Input_Student_Name_TextChanged(object sender, EventArgs e)
        {
            StudentName = input_name.Text;
        }

        private void Input_Gender_TextChanged(object sender, EventArgs e)
        {
            Gender = input_gender.Text;
        }

        private void Input_Age_TextChanged(object sender, EventArgs e)
        {
            Age = input_age.Text;
        }

        private void Input_Specialized_TextChanged(object sender, EventArgs e)
        {
            Specialized = input_specialized.Text;
        }

        private async void Confirm_Click(object sender, EventArgs e)
        {
            if (StudentNumber == "" || StudentName == "" || Age == "" || Gender == "" || Specialized == "")
            {
                AntdUI.Notification.error(this, "警告", "请先填写完整的信息", AntdUI.TAlignFrom.Top);
                return;
            }
            var client = new HttpClient();
            // 有点没看懂这个中括号有啥用，先cv
            var requestContent = new FormUrlEncodedContent(
            [
                new KeyValuePair<string, string>("student_number", StudentNumber),
                new KeyValuePair<string, string>("name", StudentName),
                new KeyValuePair<string, string>("age", Age),
                new KeyValuePair<string, string>("gender", Gender),
                new KeyValuePair<string, string>("specialized", Specialized),
            ]);
            // 这是一个虚构服务器，所以一定会404
            var response = await client.PostAsync("http://test_server.com/api/info", requestContent);
            if (response.IsSuccessStatusCode)
            {
                AntdUI.Notification.success(this, "提示", "信息上传成功", AntdUI.TAlignFrom.Top);
            } else
            {
                AntdUI.Notification.warn(this, "提示", "服务器发生错误", AntdUI.TAlignFrom.Top);
            }
        }
    }
}
