using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    public class Math : BaseClass
    {
        public List<String> FindGradeAvg(string[] data1)
        {
            List<String> Mathlist = new List<String>();
            var FinalExam = float.Parse(data1[8]);
            float total = float.Parse(data1[1]) + float.Parse(data1[2]) + float.Parse(data1[3]) + float.Parse(data1[4]) + float.Parse(data1[5]) + float.Parse(data1[6]) + float.Parse(data1[7]) + float.Parse(data1[8]);
            var average = decimal.Round((decimal)(total / 8.00), 2);
            char grade;

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

            Mathlist.Add(FinalExam.ToString());
            Mathlist.Add(average.ToString());
            Mathlist.Add(grade.ToString());

            return Mathlist;
        }
    }
}
