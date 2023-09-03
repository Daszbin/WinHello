// Decompiled with JetBrains decompiler
// Type: EdgePasswordExample.Program
// Assembly: WinHello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADA752EE-764C-4D23-AD8C-D5EF0665FA8D
// Assembly location: C:\Users\buize\OneDrive\Documents\Codernut-master\CoderNut-master\src\bin\WinHello.exe

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Security.Credentials;

namespace EdgePasswordExample
{
  public class Program
  {
    private static void Main(string[] args)
    {
      if (Program.IsProcessRunning("Coder Nut"))
        Console.WriteLine(Program.WindowsHelloAsync().Result.ToString());
      else
        Application.Exit();
    }

    private static bool IsProcessRunning(string processName) => Process.GetProcessesByName(processName).Length != 0;

    public static async Task<bool> WindowsHelloAsync() => await KeyCredentialManager.IsSupportedAsync() && (await KeyCredentialManager.RequestCreateAsync("login", (KeyCredentialCreationOption) 0)).Status == 0;
  }
}
