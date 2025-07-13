namespace testcodePushAPI.Controllers
{
    public class Hardcoded_credentials__S2068_
    {
        public void ConnectToDb()
        {
            string password = "MySecretPassword123"; 
            string connectionString = $"Server=myServer;Database=myDB;User Id=sa;Password={password};";
            Console.WriteLine(connectionString);
        }
    }
}
