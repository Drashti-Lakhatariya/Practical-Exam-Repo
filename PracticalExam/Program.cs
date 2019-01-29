using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new List<StudentDetail>();
            try
            {
                do
                {
                    Processing(studentList);
                } while (true);
            }
            catch (InvalidMarksException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Processing(List<StudentDetail> studentList)
        {
            Console.WriteLine("Press c to continue and x to exit the program");
            switch (Console.ReadKey().KeyChar)
            {
                case 'x':
                    StudentDetail.DisplayStudentDetail(studentList);
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                case 'c':
                    Console.WriteLine("\n");
                    GetStudentDetails(studentList);
                    break;

                default:
                    Console.WriteLine("\nInvalid key pressed");
                    break;
            }
        }

        private static void GetStudentDetails(List<StudentDetail> studentList)
        {
            Console.WriteLine("Enter Id :");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            var name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Maths Mark :");
            var maths = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Science Mark :");
            var science = Convert.ToDouble(Console.ReadLine());

            studentList.Add(new StudentDetail(id, name, maths, science));
        }
    }
}
