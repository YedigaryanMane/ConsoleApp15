using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        public static void Return3Lines(string path,int n)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {                
                    sw.WriteLine("The Kingdom of Armenia reached its \nheight under Tigranes the Great in the \n1st century BC and in the year 301 became the first \nstate in the world to adopt Christianity as its official religion.[20][21][22][c] Armenia still recognises the Armenian Apostolic Church, the world's oldest national church, as the country's primary\n religious establishment.[23][d] The ancient Armenian kingdom was split \nbetween the Byzantine and Sasanian Empires around the early 5th century.");
            }

            using(StreamReader sr = new StreamReader(path))
            {
                string[] str = File.ReadAllLines(path);

                for(int i = str.Length-n-1; i <str.Length; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }
        }
        public static void ReturnLinesCount(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {

                sw.WriteLine("The Kingdom of Armenia reached its \nheight under Tigranes the Great in the \n1st century BC and in the year 301 became the first \nstate in the world to adopt Christianity as its official religion.[20][21][22][c] Armenia still recognises the Armenian Apostolic Church, the world's oldest national church, as the country's primary\n religious establishment.[23][d] The ancient Armenian kingdom was split \nbetween the Byzantine and Sasanian Empires around the early 5th century.");
            }

            int count = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string[] str = File.ReadAllLines(path);

                for (int i = 0; i < str.Length; i++)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
        }

        public static void ReturnLine(string path,int n)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {

                sw.WriteLine("The Kingdom of Armenia reached its \nheight under Tigranes the Great in the \n1st century BC and in the year 301 became the first \nstate in the world to adopt Christianity as its official religion.[20][21][22][c] Armenia still recognises the Armenian Apostolic Church, the world's oldest national church, as the country's primary\n religious establishment.[23][d] The ancient Armenian kingdom was split \nbetween the Byzantine and Sasanian Empires around the early 5th century.");
            }


            using (StreamReader sr = new StreamReader(path))
            {
                string[] str = File.ReadAllLines(path);

                for (int i = 0; i < str.Length; i++)
                {
                    if (i == n)
                    {
                        Console.WriteLine(str[i]);
                    }
                }
            }
        }
        public static void ReturnValue()
        {
            
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());  
                Console.WriteLine(x/y);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program end");
            }
        }
        public static void ExistsFile(string path)
        {
            try
            {
                File.Open("", FileMode.Open);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program end");
            }
        }

        public static void ReturnArrElementAvg(int[] arr)
        {
            int sum = 0;
            int count = 0;
            try
            {
                for(int i = 0;i< arr.Length;i++)
                {
                    sum += arr[i];
                    count++;
                }
                Console.WriteLine(sum/count);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program end");
            }
        }

        public static void ReturnInteger()
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReturnNum()
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReturnNumDiv(int x, int y)
        {
            try
            {                            
                Console.WriteLine(x / y);               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            // string path = @"C:\Users\user\Desktop\New folder (6)\mytest.txt";
            // int n = Convert.ToInt32(Console.ReadLine());
            //Return3Lines(path,n);

            //string path = @"C:\Users\user\Desktop\New folder (6)\my.txt";
            //ReturnLinesCount(path);

            //int n = Convert.ToInt32(Console.ReadLine());
            //string path = @"C:\Users\user\Desktop\New folder (6)\my.txt";
            //ReturnLine(path, n);


            //ReturnValue();

            //string path = @"C:\Users\user\Desktop\New folder (6)\my.txt";
            //ExistsFile(path);

            //int[] arr = { };
            //ReturnArrElementAvg (arr);

            //ReturnInteger();

            //ReturnNum();

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            ReturnNumDiv(x,y);
            Console.ReadLine();
        }
    }
}
