using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
   public  class TestDelegate
    {
        //define the delegate 
        delegate int NumberChanger(int n);
        delegate void MulticastDelegate(int x, int y);
        static int num = 10;
        public static int AddNum(int p)
        {
          num += p;
          return num;
        }
        public static int MultNum(int q)
        {
           num *= q;
           return num;
        }
         public static int getNum()
         {
           return num;
         }
        public static int result;
        static void Main(string[] args)
        {
            //create delegate instances
            //NumberChanger nc1 = new NumberChanger(AddNum);
            //NumberChanger nc2 = new NumberChanger(MultNum);

            ////calling the methods using the delegate objects
            //nc1(25);
            //Console.WriteLine("Value of Num: {0}", getNum());
            //nc2(5);
            //Console.WriteLine("Value of Num: {0}", getNum());

            //MulticastDelegate objfunc = new MulticastDelegate(MultiCast.Method1);

            //objfunc += new MulticastDelegate(MultiCast.Method2);

            //objfunc(10, 20);             // Method1 and Method2 are called

            //objfunc -= new MulticastDelegate(MultiCast.Method1);

            //objfunc(40, 50);             // Only Method2 is called
            FuncType funcType = new FuncType();
            Func<int, int, int> Addition =funcType.AddNumbers;
            int result = Addition(10, 20);
            Console.WriteLine($"Addition = {result}");
            ActionType actionType = new ActionType();
            Action<int, int> Addition1 = actionType.MulNumbers;
            Addition1(30, 20);

            PredicatDelegate predicatDelegate = new PredicatDelegate();
            Predicate<string> CheckIfApple = predicatDelegate.IsApple;
            bool result1 = CheckIfApple("I Phone X");
            if (result1)
                Console.WriteLine("It's an IPhone");
            Console.ReadLine();
        }
   }
}

