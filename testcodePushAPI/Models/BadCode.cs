namespace testcodePushAPI.Models
{
    public class BadCode
    {
        // Bad naming convention
        public int a;
        public string b;

        // Dead code (không bao giờ dùng)
        private int unusedValue = 42;

        // Method quá dài (code smell)
        public void VeryLongMethod()
        {
            Console.WriteLine("Start");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Line {i}");
            }
            Console.WriteLine("End");
        }

        // Potential bug: division by zero
        public int Divide(int number)
        {
            int zero = 0;
            return number / zero;
        }

        // Duplicate code (code smell)
        public void DuplicateCode()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
        }

        // Unused parameter (code smell)
        public void PrintMessage(string message)
        {
            Console.WriteLine("This does not use the parameter.");
        }

        // Complex nested block (code smell)
        public void ComplexMethod()
        {
            if (true)
            {
                if (true)
                {
                    if (true)
                    {
                        Console.WriteLine("Deep nesting");
                    }
                }
            }
        }
    }
}
