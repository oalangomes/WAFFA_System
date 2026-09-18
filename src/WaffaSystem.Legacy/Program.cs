using WaffaSystem.Legacy.UI;

namespace WaffaSystem.Legacy;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
