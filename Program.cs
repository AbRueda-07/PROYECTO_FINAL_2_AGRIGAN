using System;
using System.Windows.Forms;
using AgriGanAsistenteJutiapa.UI;

namespace AgriGanAsistenteJutiapa
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());



        }
    }
}
