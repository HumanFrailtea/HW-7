/// Homework No.__ Exercise No.__
/// File Name:     HW 6.sln
/// @author:       Upendra Samaranayake
/// Date:          October 12, 2020
///
/// Problem Statement: Define a class called Counter whose objects count things. 
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Make a new counter.
/// 2. Test the increment and toString() methods.
/// 3. Test the decrement and output methods.
/// 4. Test the output method.
/// 5. Make a second counter to test equals.
/// 6. Increment counter2 so that they are equal.
/// 7. Reset counter2 to zero.
/// etc.

using System;

namespace HW_7
{
    class CounterDemo
    {

        public static void Main(string[] args)
        {
          
            Counter counter = new Counter();
            Console.WriteLine("Initial value is " + counter.Value);

 
            counter.increment();
            counter.increment();
            Console.WriteLine("After two increments, value is " + counter.ToString());

            counter.decrement();
            Console.WriteLine("After one decrement, value is " + counter);

            Console.WriteLine("Result of calling counter.output() :");
            counter.output();

            Counter counter2 = new Counter();
            Console.WriteLine(counter + " equals " + counter2 + "? " + counter.Equals(counter2));
 
            counter2.increment();
            Console.WriteLine(counter + " equals " + counter2 + "? " + counter.Equals(counter2));

            counter2.resetToZero();
            Console.WriteLine("After resetting to zero, value is " + counter2);
        }

    }

    internal class Counter
    {
        private int value = 0;

        public virtual void increment()
        {
            value = value + 1;
        }
        public virtual void decrement()
        {
            if (value > 0)
            {
                value = value - 1;
            }
            else
            {
                Console.WriteLine("cannot decrement counter !!");
            }
        }
        public virtual int Value
        {
            get
            {
                return value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0:D}", value);
        }
        public virtual void resetToZero()
        {
            value = 0;
        }
        public virtual bool Equals(Counter C)
        {
            if (this.Value == C.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    


        public virtual void output()
        {
            Console.WriteLine("Counter value is " + value);
        }

    }
}
