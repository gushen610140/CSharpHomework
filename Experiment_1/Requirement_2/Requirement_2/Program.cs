using AntdUI;

namespace Requirement_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // �����Ӿ���ʽ
            Application.EnableVisualStyles();
            // �������õ��ı���ʾ
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(new MainForm());
        }
    }
}