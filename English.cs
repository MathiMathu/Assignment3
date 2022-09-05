using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    public class English : BaseClass
    {
        public List<String> FindGradeAvg(string[] data1)
        {
            List<String> Englishlist = new List<String>();
            var FinalExam = float.Parse(data1[3]);
            float total = float.Parse(data1[1]) + float.Parse(data1[2]) + float.Parse(data1[3]);
            var average = decimal.Round((decimal)(total / 3.00), 2);
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

            Englishlist.Add(FinalExam.ToString());
            Englishlist.Add(average.ToString());
            Englishlist.Add(grade.ToString());

            return Englishlist;
        }
      
    }
}
