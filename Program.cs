namespace Prog260_W24_L3_011724
{
    internal class Program
    {
        static int[] array = { 1, 2, 3, 4, 5 };
        static void Main(string[] args)
        {


            // For - Iterative
            // While
            // Do While
            // Goto

            // Merge Sort

        } // Main

        // Recursive Examples

        public static void RecursiveSumExample()
        {
            //int sumIterative = SumIterative(array);

            //Console.WriteLine($"The sum of our iterative sum method is {sumIterative}");

            //int recursiveSum = SumRecursive(array, 0);

            //Console.WriteLine($"The sum of our recursive sum method is {sumIterative}");
        }


        public static void OneToTenIterative()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void TowerOfHanoi(int n, char source, char destination, char auxiliary)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from {source} to {destination}");
                return;
            }

            TowerOfHanoi(n - 1, source, auxiliary, destination);

            Console.WriteLine($"Move disk {n} from {source} to {destination}");

            TowerOfHanoi(n - 1, auxiliary, destination, source);
        }

        public static int SumIterative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        
        public static int SumRecursive(int[] array, int index)
        {
            // Base case
            if (index >= array.Length) return 0;
            Console.WriteLine(array[index]);

            int value = array[index];

            // Parameters
            // Recursive call
            return value + SumRecursive(array, index + 1);

            // value + 0
            // 5 + 0
            // 4 + 5

 
            // Return
            // Control flow
            // Functional Call

        }

        public static int Factorial(int n)
        {
            // Base case
            if (n == 0) return 1;
            else
            {
                // Return call and Recursive call
                return n * Factorial(n - 1);
            }

        }

        static long Fibonacci(int n)
        {
            // Display what's happening with each call
            Console.WriteLine($"Calculating Fibonacci({n})");

            if (n <= 1)
            {
                return n;
            }
            else
            {
                // Recursively call Fibonacci and display what's happening
                long result = Fibonacci(n - 1) + Fibonacci(n - 2);
                Console.WriteLine($"Fibonacci({n}) = {result}");
                return result;
            }
        }

        // Parameters
        public static void OneToTenRecursion(int number, int end)
        {
            // Base case
            // Return
            if (number >= end) return;

            int incrementByOne = number + 1;

            // Control Flow
            Console.WriteLine(number);

            OneToTenRecursion(incrementByOne, end);

            Console.WriteLine(number);
            // Recursive Case

            // Functional Call

        } //OneToTenRecursion

        public static void InfinteRecursion()
        {
            // Recursive Call
            // Call Itself
            InfinteRecursion();
        }

        public static void DisplaySomething()
        {
            Console.WriteLine("Top of Method");

            Console.WriteLine("Bottom Of Method");
        }

        public static double AddTwoNumbers(double a, double b)
        {
            return a + b;
        }


    } // class



} // namespace
