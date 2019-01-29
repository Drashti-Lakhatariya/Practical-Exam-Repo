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
            int id;
            string name;
            double maths = 0;
            double science = 0;

            StudentDetail s1;
            List<StudentDetail> std = new List<StudentDetail>();

            try
            {
                do
                {
                    Console.WriteLine("Press c to continue and x to exit the program");
                    var ch = Console.ReadKey().KeyChar;
                    if (!(ch.Equals('c') || ch.Equals('x')))
                    {
                    }
                    
                    switch (ch)
                    {
                        case 'x':
                            StudentDetail.DisplayStudentDetail(std);
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        case 'c':
                            Console.WriteLine("\n");

                            Console.WriteLine("Enter Id :");
                            id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Name :");
                            name = Convert.ToString(Console.ReadLine());

                            try
                            {
                                Console.WriteLine("Enter Maths Mark :");
                                maths = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter Science Mark :");
                                science = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (InvalidMarksException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("invalid input");
                            }

                            s1= new StudentDetail(id, name, maths, science);
                            std.Add(s1);
                            break;

                        default:
                            Console.WriteLine("\nInvalid key pressed");
                            break;
                    }
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
