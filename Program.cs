using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int res,i;
            int temp1, temp2;
            //Console.WriteLine("Enter the operation: ");
            Console.WriteLine("Enter RPN series (example 2,3,+) : ");
            string s = Console.ReadLine();
            //for (i=1;i<=3;i++)
            //{
                temp1 = Convert.ToInt32(s.Substring(1));
                temp2 = Convert.ToInt32(s.Substring(2));
            res = temp2 + temp1;
            //}*/
            
            Program objP = new Program();
            objP.GetInput();
        }
        public void GetInput()
        {
            int temp1, temp2,res;
            Console.WriteLine("Enter RPN series (example 2,3,+) : ");
            string s = Console.ReadLine();
            temp1 = Convert.ToInt32(s.Substring(1));
            temp2 = Convert.ToInt32(s.Substring(2));
            res = AddNum(temp2, temp1);
        }
        public int AddNum(int n1,int n2)
        {
            int res;
            res = n1 + n2;
            return res;
        }
    }
}
