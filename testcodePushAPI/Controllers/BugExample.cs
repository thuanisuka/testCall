namespace testcodePushAPI.Controllers
{
    public class BugExample
    {
        // Dead code (unused private field)
        private int unusedValue = 123;

        // Bad naming convention (public field, lowercase)
        public int a;

        // Hardcoded credentials (security hotspot)
        public string ConnectionString = "Server=localhost;User Id=admin;Password=123456;";

        // Magic number
        public int CalculatePrice(int quantity)
        {
            return quantity * 999; // magic number
        }

        // Method too long, deep nesting, null dereference, magic numbers
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

            // Commented out code (bad practice)
            // var temp = File.ReadAllText("file.txt");

            Console.WriteLine("End of bug demo");
        }

        // Duplicate code (bad)
        public void Duplicate()
        {
            Console.WriteLine("Duplicate");
            Console.WriteLine("Duplicate");
            Console.WriteLine("Duplicate");
        }

        // Resource not disposed
        public void ReadFile()
        {
            var fs = new FileStream("test.txt", FileMode.Open);
            var reader = new StreamReader(fs);
            Console.WriteLine(reader.ReadToEnd());
            // forgot: reader.Dispose(); fs.Dispose();
        }

        // Empty catch block
        public void IgnoreError()
        {
            try
            {
                int x = int.Parse("not_a_number");
            }
            catch
            {
