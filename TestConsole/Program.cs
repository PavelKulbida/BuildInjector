﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(ConfigurationManager.AppSettings["Text"]);
      Console.ReadKey();
    }
  }
}
