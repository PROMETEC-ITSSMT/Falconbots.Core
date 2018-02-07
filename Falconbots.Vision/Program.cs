namespace Falconbots.Vision
{
    using System;
    class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new FalconBots.Vision.MainForm());
        }
    }
}
