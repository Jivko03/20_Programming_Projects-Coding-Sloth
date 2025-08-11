using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIt___basic_version
{
    public class git_init
    {
       /* if (args.Length< 1)
        {
            Console.WriteLine("Please provide a command.");
            return;
        }

    // You can use print statements as follows for debugging, they'll be visible when running tests.
    Console.Error.WriteLine("Logs from your program will appear here!");

        string command = args[0];*/

    public void start(string path) {
        // Uncomment this block to pass the first stage
        //
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(".git");
            Directory.CreateDirectory(".git/objects");
            Directory.CreateDirectory(".git/refs");
            File.WriteAllText(".git/HEAD", "ref: refs/heads/main\n");
            Console.WriteLine("Initialized git directory");
        }
        else
        {
            Console.WriteLine("Directory already exists.");
        }
    }
}
     
    }
    public class git_add
    {
    }
    public class git_branch
    {
    }
    public class git_checkout
    {
    }
    public class git_clean
    {
    }
    public class git_clone
    {
    }
    public class git_commit
    {
    }
    public class git_commit_amend//git commit--amend
    {
    }
    public class git_config
    {
    }
    public class git_fetch
    {
    }
    public class git_log
    {
    }
    public class git_merge
    {
    }
    public class git_pull
    {
    }
    public class git_push
    {
    }
    public class git_rebase
    {
    }
    public class git_rebase_i//git rebase -i
    {
    }
    public class git_reflog
    {
    }
    public class git_remote
    {
    }
    public class git_reset
    {
    }
    public class git_revert
    {
    }
    public class git_status
    {
    }
    internal class Program
    {
        /*const string joe = "joe";
        const string joeinit = "joe init";
        const string joeclone = "joe clone";
        const string joeadd = "joe add";
        const string joecommit = "joe commit";*/
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft Windows [Version very.seriouse.number.probably]\r\n(c) Microsoft Corporation. All rights reserved. \n\n");
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string path = @"C:\Users\"+userName+"";
            bool exit = false;
            while (exit == false)
            {
                Console.Write(path + ">");
                string commandInput = Console.ReadLine();
                switch (commandInput)
                {
                    case "exit":
                        exit = true;
                        break;
                    case "git init":
                        Console.WriteLine();
                        continue;
                    case "git add":
                        Console.WriteLine();
                        continue;
                    case "git branch":
                        Console.WriteLine();
                        continue;
                    case "git checkout":
                        Console.WriteLine();
                        continue;
                    case "git clean":
                        Console.WriteLine();
                        continue;
                    case "git clone":
                        Console.WriteLine();
                        continue;
                    case "git commit":
                        Console.WriteLine();
                        continue;
                    case "git commit --amend":
                        Console.WriteLine();
                        continue;
                    case "git config":
                        Console.WriteLine();
                        continue;
                    case "git fetch":
                        Console.WriteLine();
                        continue;
                    case "git log":
                        Console.WriteLine();
                        continue;
                    case "git merge":
                        Console.WriteLine();
                        continue;
                    case "git pull":
                        Console.WriteLine();
                        continue;
                    case "git push":
                        Console.WriteLine();
                        continue;
                    case "git rebase":
                        Console.WriteLine();
                        continue;
                    case "git rebase -i":
                        Console.WriteLine();
                        continue;
                    case "git reflog":
                        Console.WriteLine();
                        continue;
                    case "git remote":
                        Console.WriteLine();
                        continue;
                    case "git reset":
                        Console.WriteLine();
                        continue;
                    case "git revert":
                        Console.WriteLine();
                        continue;
                    case "git status":
                        Console.WriteLine();
                        continue;
                    default:
                        Console.WriteLine("'{0}' is not recognized as an internal or external command,\r\noperable program or batch file.\n", commandInput);
                        break;
                }
            }
            System.Environment.Exit(0);
        }
    }
}
