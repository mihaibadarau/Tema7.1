using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Net;

namespace Tema7._1
{
    class Program
    {

        static void Main(string[] args)
        {
            //////1. Write a program that enters file name along with its full file path(e.g.C:\WINDOWS\win.ini), reads its contents and prints it on the console.Find in 
            //////   MSDN how to use System.IO.File.ReadAllText(...). Be sure to catch all possible exceptions and print user-friendly error messages.

            //Console.Write("Enter file path: ");
            //string filePath = Console.ReadLine();

            //try
            //{
            //    Console.WriteLine(File.ReadAllText(filePath));
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Fisierul nu a fost gasit.");
            //}
            //catch (PathTooLongException)
            //{
            //    Console.WriteLine("Locatia, numele sau amandoua au depasit numarul maxim de caractere admis");
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.WriteLine("Locatia nu exista");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("Locatia fisierului este incorecta");
            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Console.WriteLine("Path specified a file that is read-only. \n -or- This operation is not supported on the current platform.\n -or- Path specified a directory.\n -or- The caller does not have the required permission.");
            //}
            //catch (NotSupportedException)
            //{
            //    Console.WriteLine("Path is in an invalid format.");
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("An I/O error occurred while opening the file.");
            //}
            //catch (SecurityException)
            //{
            //    Console.WriteLine("Nu aveti permisiunea pentru a accesa acest fisier");
            //}

            //2.Write a program that downloads a file from Internet (e.g.Ninja image) and stores it the current directory. Find in Google how to download files in C#. 
            //Be sure to catch all exceptions and to free any used resources in the finally block.

            //Console.Write("Enter URL of the file: ");
            //string url = Console.ReadLine();

            //Console.Write("Enter directory where you want to store the file: ");
            //string directory = Console.ReadLine();

            //WebClient webClient = new WebClient();

            //try
            //{
            //    webClient.DownloadFile(url, directory);
            //    Console.WriteLine("Download complete!");
            //}
            //catch (WebException)
            //{
            //    Console.WriteLine("Invalid address -or- Empty file -or- The file does not exist.");
            //}
            //catch (NotSupportedException)
            //{
            //    Console.WriteLine("The method has been called simultaneously on multiple threads.");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Invalid address. The address cannot be null.");
            //}
            //finally
            //{
            //    webClient.Dispose();
            //}

            //3.Write a method ReadNumber(int start, int end) that enters an integer number in a given range(start, end).
            //If an invalid number or non-number text is entered, the method should throw an exception.Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100
            //Output
            //Print 1 < a1 < ... < a10 < 100
            //Or Exception if the above inequality is not true

            int ReadNumber(int start, int end, int i)
            {
                int number = int.Parse(Console.ReadLine());

                if ((number < start) || (number > end) || (number < i))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return number;
            }

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Introduceti numarul {0} : ", i, 1, 10);
                    int number = ReadNumber(1, 100, i);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("The number is NOT integer!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null is NOT integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is NOT in the range of integer.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is NOT in the range.");
            }
        }
    }
}
