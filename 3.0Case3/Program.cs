using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0Case3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Sign Up. ");
            Console.WriteLine("Press 2 For Login. ");
            var input =Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Choose An Name: ");
                        string Name = Console.ReadLine();
                    Console.Write("Type Your Password: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  \nPassword must be a minimum of 12 characters. \nUse both upper and lower case letters. \nUse one or more numbers and special characters such as, !, %,#  \nNumbers must not be at the beginning or at the end of the password. \nMust not contain spaces");
                            Console.ResetColor();
                        String Pass = Console.ReadLine();
                if (Pass.Length < 12)
                {
                    Console.Error.WriteLine("Pass under 12 characters!!! ");
                }
                else if (Pass.Length > 12)
                {       
                    string Nam = Name;
                    System.IO.File.WriteAllText(@"C:\Users\adeaje\Documents\IT\1.HF\Projects I Made\C#\C# Console App(NET F)\3.0Case3\3.0Case3\Names.txt", Nam);
                    string Pas = Pass;
                    System.IO.File.WriteAllText(@"C:\Users\adeaje\Documents\IT\1.HF\Projects I Made\C#\C# Console App(NET F)\3.0Case3\3.0Case3\Passwords.txt", Pas);
                    
                    Console.WriteLine("Now You Got An Account:) ");
                }
                }
                else if (input == 2)
            {
                Console.WriteLine("Your ID: ");
                String Name = Console.ReadLine();
                Console.WriteLine("Your Pass: ");
                String Pass = Console.ReadLine();

                if (Name == @"C:\Users\adeaje\Documents\IT\1.HF\Projects I Made\C#\C# Console App(NET F)\3.0Case3\3.0Case3\Names.txt" && Pass == @"C:\Users\adeaje\Documents\IT\1.HF\Projects I Made\C#\C# Console App(NET F)\3.0Case3\3.0Case3\Passwords.txt")
                {
                    Console.WriteLine(Name + Pass);
                }
            }

                else
            {
                Console.WriteLine("Try again !!!");
            }
        }
    }
}



