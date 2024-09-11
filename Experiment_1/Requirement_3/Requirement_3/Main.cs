namespace Requirement_3
{
    public partial class Main : AntdUI.Window
    {
        public Main()
        {
            InitializeComponent();

            label.MouseDown += Window_MouseDown;
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
    }
}
