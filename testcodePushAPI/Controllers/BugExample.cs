namespace testcodePushAPI.Controllers
{
    public class BugExample
    {
        public void ShowBug()
        {
            string value = null;
            Console.WriteLine(value.ToString()); // <-- NullReferenceException
        }
    }
}
