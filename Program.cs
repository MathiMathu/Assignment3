using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            English english = new English();
            Science science = new Science();
            Math math = new Math();
            List<String> Englishlist = new List<String>();
            List<String> Sciencelist = new List<String>();
            List<String> Mathlist = new List<String>();

            string fileName = @"C:\Input\Input.txt";
            var count = File.ReadLines(fileName).First();
            IEnumerable<string> lines = File.ReadLines(fileName);

            using (var reader = new StreamReader(fileName))
            {
                reader.ReadLine(); // skip

                for (int i = 0; i < Convert.ToInt32(count); i++)
                {
                    var name = reader.ReadLine();
                    var data = name.Split(',');

                    var subject = reader.ReadLine();
                    var data1 = subject.Split(' ');

                    if ((data1[0]).ToString() == "English" && (data1[0]).ToString() != null)
                    {
                        Englishlist.Add((data[0]).ToString());
                        Englishlist.Add((data[1]).ToString());

                        List<String> list = english.FindGradeAvg(data1);
                        foreach (var element in list)
                        {
                            Englishlist.Add(element);
                        }
                    }
                    else if ((data1[0]).ToString() == "Science" && (data1[0]).ToString() != null)
                    {
                        Sciencelist.Add((data[0]).ToString());
                        Sciencelist.Add((data[1]).ToString());
                        List<String> list = science.FindGradeAvg(data1);
                        foreach (var element in list)
                        {
                            Sciencelist.Add(element);
                        }
                    }
                    else if ((data1[0]).ToString() == "Math" && (data1[0]).ToString() != null)
                    {
                        Mathlist.Add((data[0]).ToString());
                        Mathlist.Add((data[1]).ToString());
                        List<String> list = math.FindGradeAvg(data1);
                        foreach (var element in list)
                        {
                            Mathlist.Add(element);
                        }
                    }
                }
            }
           
            int English_CountA = 0;
            int English_CountB = 0;
            int English_CountC = 0;
            int English_CountD = 0;
            int English_CountF = 0;

            int Science_CountA = 0;
            int Science_CountB = 0;
            int Science_CountC = 0;
            int Science_CountD = 0;
            int Science_CountF = 0;

            int Math_CountA = 0;
            int Math_CountB = 0;
            int Math_CountC = 0;
            int Math_CountD = 0;
            int Math_CountF = 0;

            StreamWriter sw = new StreamWriter(@"C:\Output\Output.txt");

            sw.WriteLine("Student Grade Summary");
            sw.WriteLine("---------------------");
            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("ENGLISH CLASS");
            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("Student                                   Final Final   Letter");
            sw.WriteLine("Name                                      Exam  Avg     Grade");
            for (int i = 0; i < Englishlist.Count; i = i + 5)
            {
                sw.WriteLine(Englishlist[i] + " " + Englishlist[i + 1] + "                              " + Englishlist[i + 2] + "    " + Englishlist[i + 3] + "    " + Englishlist[i + 4]);
                if (Englishlist[i + 4].Equals("A"))
                {
                    English_CountA = English_CountA + 1;
                }
                else if (Englishlist[i + 4].Equals("B"))
                {
                    English_CountB = English_CountB + 1;
                }
                else if (Englishlist[i + 4].Equals("C"))
                {
                    English_CountC = English_CountC + 1;
                }
                else if (Englishlist[i + 4].Equals("D"))
                {
                    English_CountD = English_CountD + 1;
                }
                else if (Englishlist[i + 4].Equals("F"))
                {
                    English_CountF = English_CountF + 1;
                }
            }

            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("SCIENCE CLASS");
            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("Student                                   Final Final   Letter");
            sw.WriteLine("Name                                      Exam  Avg     Grade");
            for (int i = 0; i < Sciencelist.Count; i = i + 5)
            {
                sw.WriteLine(Sciencelist[i] + " " + Sciencelist[i + 1] + "                             " + Sciencelist[i + 2] + "    " + Sciencelist[i + 3] + "    " + Sciencelist[i + 4]);
                if (Sciencelist[i + 4].Equals("A"))
                {
                    Science_CountA = Science_CountA + 1;
                }
                else if (Sciencelist[i + 4].Equals("B"))
                {
                    Science_CountB = Science_CountB + 1;
                }
                else if (Sciencelist[i + 4].Equals("C"))
                {
                    Science_CountC = Science_CountC + 1;
                }
                else if (Sciencelist[i + 4].Equals("D"))
                {
                    Science_CountD = Science_CountD + 1;
                }
                else if (Sciencelist[i + 4].Equals("F"))
                {
                    Science_CountF = Science_CountF + 1;
                }
            }

            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("MATH CLASS");
            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("Student                                   Final Final   Letter");
            sw.WriteLine("Name                                      Exam  Avg     Grade");
            for (int i = 0; i < Mathlist.Count; i = i + 5)
            {
                sw.WriteLine(Mathlist[i] + " " + Mathlist[i + 1] + "                             " + Mathlist[i + 2] + "    " + Mathlist[i + 3] + "    " + Mathlist[i + 4]);
                if (Mathlist[i + 4].Equals("A"))
                {
                    Math_CountA = Math_CountA + 1;
                }
                else if (Mathlist[i + 4].Equals("B"))
                {
                    Math_CountB = Math_CountB + 1;
                }
                else if (Mathlist[i + 4].Equals("C"))
                {
                    Math_CountC = Math_CountC + 1;
                }
                else if (Mathlist[i + 4].Equals("D"))
                {
                    Math_CountD = Math_CountD + 1;
                }
                else if (Mathlist[i + 4].Equals("F"))
                {
                    Math_CountF = Math_CountF + 1;
                }
            }

            sw.WriteLine("");
            sw.WriteLine("");

            sw.WriteLine("Number of A:   " + (English_CountA + Science_CountA + Math_CountA));
            sw.WriteLine("Number of B:   " + (English_CountB + Science_CountB + Math_CountB));
            sw.WriteLine("Number of C:   " + (English_CountC + Science_CountC + Math_CountC));
            sw.WriteLine("Number of D:   " + (English_CountD + Science_CountD + Math_CountD));
            sw.WriteLine("Number of F:   " + (English_CountF + Science_CountF + Math_CountF));

            sw.Close();
        }
    
    }
}
