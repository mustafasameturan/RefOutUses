using System;

namespace RefOutUses
{
    class RefExample
    {
        static void Main(string[] args)
        {
            int mainValue = 30;
            Console.WriteLine("Before use RefExample: " + mainValue);

            UseRef useRef = new UseRef();
            useRef.refExample(5, 6, ref mainValue);
            Console.WriteLine("After use RefExampe: " + mainValue);

            
        }
    }

    class UseRef
    {
        public void refExample(int x, int y, ref int i)
        {
            i = i + x + y;
        }

    }
}
