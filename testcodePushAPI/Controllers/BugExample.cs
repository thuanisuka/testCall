namespace testcodePushAPI.Controllers
{
    public class BugExample
    {
        // Dead code (unused private field)
        private int unusedValue = 123;

        // Bad naming convention
        public int a;

        // Method too long (code smell)
        public void ShowBug()
        {
            string value = null;
            Console.WriteLine(value.ToString()); // <-- NullReferenceException

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Spam line " + i);
            }

            if (true)
            {
                if (true)
                {
                    if (true)
                    {
                        Console.WriteLine("Too deep nesting");
                    }
                }
            }

            Console.WriteLine("End of bug demo");
        }

        // Duplicate code (bad)
        public void Duplicate()
        {
            Console.WriteLine("Duplicate");
            Console.WriteLine("Duplicate");
            Console.WriteLine("Duplicate");
        }
    }
}
