using System;
using System.Linq;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(withNoOSDArg(args));
        Process.Start(new ProcessStartInfo(@"C:\Program Files (x86)\VideoLAN\VLC\original vlc.exe", withNoOSDArg(args)));
#if DEBUG
        Console.ReadLine();
#endif
    }

    static string withNoOSDArg(string[] args)
    {
        return "--no-osd " + string.Join(" ", args.Select(arg => "\"" + arg + "\""));
    }
}