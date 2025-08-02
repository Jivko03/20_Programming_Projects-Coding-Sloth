using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIt___basic_version
{
    internal class Program
    {
        const string joe = "joe";
        const string joeinit = "joe init";
        const string joeclone = "joe clone";
        const string joeadd = "joe add";
        const string joecommit = "joe commit";
        static void Main(string[] args)
        {
            string commandInput = Console.ReadLine();
            string path_to_create = @"C:\Users\Tamuring\Desktop\20 Programming projects\Git\Git code\template made projects with my sudo-git\.joe";
            string path_to_clone = @"C:\Users\Tamuring\Desktop\20 Programming projects\Git\Git code\template made projects with my sudo-git";
            switch (commandInput)
            {
                case "joe init":
                    if 
                        (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        Console.WriteLine("Directory created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Directory already exists.");
                    }
                    break;

                case "joe clone":
                    if
                        (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        Console.WriteLine("Directory created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Directory already exists.");
                    }
                    break;

                case "joe add":
                    Console.WriteLine("Failed measurement.");
                    break;
                case "joe commit":
                    Console.WriteLine("Failed measurement.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {measurement}.");
                    break;
            }
        }
    }
}
