using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam
{
    class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message)
        {
         //   Console.WriteLine("invalidmarksexception");
        }
    }
}
