namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputDateStr = Console.ReadLine();
            DateTime inputDate = DateTime.ParseExact(inputDateStr, "dd/MM/yyyy", null);
            DateTime newDate = inputDate.AddDays(30).AddHours(6).AddMinutes(17);
            Console.WriteLine(newDate.ToString("dd/MM/yyyy"));
        }
    }
}