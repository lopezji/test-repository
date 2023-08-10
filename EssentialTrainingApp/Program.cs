using System;
using System.Collections.Generic;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();

        }
        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"E:\Training\OptiPlantTestProject\tem\tem.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);

                }
            }
            catch (System.IO.FileNotFoundException ex )
            {
                 Console.WriteLine("Could not find text File");
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found");
            }
            //add a general exception
            catch(Exception ex)
            {
                Console.WriteLine("Unknown error " + ex.Message);
            }

            finally // to clean things up if somehting happens
            {
                Console.WriteLine("The Finally runs all the time");
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; --i)
            {
                income = income = (income / i);
                 
            }
            return income;
        }
    }
}
