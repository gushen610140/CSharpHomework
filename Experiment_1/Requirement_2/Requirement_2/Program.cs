using AntdUI;

namespace Requirement_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // 启用视觉样式
            Application.EnableVisualStyles();
            // 启动更好的文本显示
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(new MainForm());
        }
    }
}