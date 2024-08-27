using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter07.Examples.Examples
{
    internal class Ex001
    {
        public void Run()
        {
            Console.Write("숫자를 입력 하세요 : ");

            int number = Convert.ToInt32(Console.ReadLine());
            // intput value : "one"

            Console.WriteLine("입력된 숫자는 {0}", number);
        }
    }
}
