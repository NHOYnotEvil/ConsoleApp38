namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int numberRepetitions;

            Console.Write("Введите повторяемое сообщение: ");
            userMessage = Console.ReadLine();
            Console.Write("Введите кол-во повторов: ");
            numberRepetitions = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numberRepetitions; i++)
            {
                Console.WriteLine(userMessage);
            }
        }
    }
}