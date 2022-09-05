using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    public class Science : BaseClass
    {
        public List<String> FindGradeAvg(string[] data1)
        {
            List<String> Sciencelist = new List<String>();
            var FinalExam = float.Parse(data1[4]);
            float total = float.Parse(data1[1]) + float.Parse(data1[2]) + float.Parse(data1[3]) + float.Parse(data1[4]);
            var average = decimal.Round((decimal)(total / 4.00), 2);
            Char grade;
            if (average > 90)
            {
                grade = 'A';
            }
            else if (average > 80)
            {
                grade = 'B';
            }
            else if (average > 70)
            {
                grade = 'C';
            }
            else if (average > 50)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F'; ;
            }

            Sciencelist.Add(FinalExam.ToString());
            Sciencelist.Add(average.ToString());
            Sciencelist.Add(grade.ToString());

            return Sciencelist;
        }
    }
}
