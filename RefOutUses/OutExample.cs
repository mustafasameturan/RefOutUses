using System;


namespace RefOutUses
{
    class OutExample
    {

        static void Main(String[] args)
        {
            int variable;
            UseOut(out variable);
            Console.WriteLine(variable);
        }
        static void UseOut(out int numberOut)
        {
            numberOut = 1234;
        }

    }
}
   
