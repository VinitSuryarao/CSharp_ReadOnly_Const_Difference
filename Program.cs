using System;

namespace ReadOnly_Const_Defference
{
    class Program
    {
        // Way 1 : Declare Varibale and Assign value 
        public readonly int Number1 = 605;
        Number1=804; // Once assgin valut it will not allow to change



        // Way 2 : Declare Varibale and Assign value in constructor
        public readonly int Number2;
        
        // Assign Value only in Constructor
         Program()
        {
            Number2 = 455;
        }
        Number2=804; // Once assgin valut it will not allow to change



        static void Main(string[] args)
        {
            // Cont varibale cannot just declare, need to assign value.
            public const int Number3;

            // Cont varibale cannot just declare, need to assign value.
            const int Number4 =405;

            Number4 = 804; // Once assgin valut it will not allow to change
        }
    }
}
