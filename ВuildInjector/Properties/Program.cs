using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInjector
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Count() < 2)
      {
        Console.WriteLine("give me 'project' and 'output' path parameters");
      }

      Console.WriteLine("----------------------------  Start build injector --------------------------------------------------------");

      Console.WriteLine($"Output: {args[0]}");
      Console.WriteLine($"Project: {args[1]}");
      Console.WriteLine($"Solution: {args[2]}");
      Console.WriteLine($"Configuration: {args[3]}");
      Console.WriteLine($"Platform: {args[4]}");

      var j2Files = Directory.EnumerateFiles($"{args[1]}")
        .Where(x => Path.GetExtension(x) == ".j2");

      foreach(var j2File in j2Files)
      {
        Console.WriteLine(j2File);
        var name = Path.GetFileNameWithoutExtension(j2File);
        var newFileName = $"{args[0]}{name}";
        Console.WriteLine(newFileName);

        File.Copy(j2File, newFileName, true);
      }





      Console.WriteLine("----------------------------  Finish build injector --------------------------------------------------------");
    }
  }
}
