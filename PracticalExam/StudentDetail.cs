using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam
{
    class StudentDetail
    {
        private string _grade;
        private int _id;
        private string _studentName;
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
                    throw new InvalidMarksException("Invalid marks exception Maths");
                }
            }
        }

        private double _science;
        public double Science
        {
            get { return _science; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _science = value;
                }
                else
                {
                    throw new InvalidMarksException("Invalid marks exception Science");
                }
            }
        }

        private double _total;

        public StudentDetail(int id, string name, double mathsMark, double scienceMark)
        {
            _id = id;
            _studentName = name;
            Maths = mathsMark;
            Science = scienceMark;
            _total = mathsMark + scienceMark;

            if (_total > 95)
            {
                _grade = "Grade A...";
            }
            else if (_total >= 85 && _total <= 95)
            {
                _grade = "Grade B...";
            }
            else
            {
                _grade = "Grade C...";
            }
        }

        public static void DisplayStudentDetail(List<StudentDetail> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine("\n" + student._studentName + " : Totla Marks = " + student._total + " Grade = " + student._grade);
            }
        }
    }
}
