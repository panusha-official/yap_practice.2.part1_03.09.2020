﻿using System;
using System.IO;

namespace PANIN_ILYA_BACO._02._19_PRAKTIKA_3
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamWriter writer = File.CreateText(@"c:\newfile.txt"); 
      writer.WriteLine("This is my new file"); 
      writer.WriteLine("Do you like its format?"); 
      writer.Close();

      StreamReader reader = File.OpenText(@"c:\newfile.txt");
      string contents = reader.ReadToEnd();
      reader.Close();
      Console.WriteLine(contents);
    }
  }
}
