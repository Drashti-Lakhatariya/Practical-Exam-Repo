using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam
{
    class StudentDetail
    {
        string Grade;
        public int Id { get; set; }
        public string StudentName { get; set; }
        
        private double _maths;
        public double Maths
        {
            get { return _maths; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _maths = value;
                }
                else
                {
                    throw new InvalidMarksException("invalidmarksexception");
                    
                }
            }
        }

        private double _science;
        public double Science
        {
            get { return _science; }
            set
            {
                if (value <= 50 && value >= 0)
                {
                    _science = value;
                }
                else
                {
                    throw new InvalidMarksException(" invalidmarksexception");
                }
            }
        }

        public double Total { get; set; }

        public StudentDetail(int i, string n, double m, double s)
        {
            Id = i;
            StudentName = n;
            Maths = m;
            Science = s;
            Total = m + s;

            if (Total > 95 && Total <= 100)
            {
                Grade = "Grade A...";

            }
            else if (Total >= 85 && Total <= 95)
            {
                Grade = "Grade B...";

            }
            else
            {
                Grade = "Grade C...";

            }

        }

        public static void DisplayStudentDetail(List<StudentDetail> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine("\n" + student.StudentName + " : Totla Marks = " + student.Total + " Grade = " + student.Grade);

            }
        }
    }
}
