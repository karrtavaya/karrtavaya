namespace karrtavaya;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("выберите команду");
        while (true)
        {
            var command = Console.ReadLine().ToLower().Split(' ');
            Controller s = new Controller();
            switch (command[0])
            {
                case "добавить":
                    s.AddGood(command[1], float.Parse(command[2]),float.Parse(command[3]));
                    break;
                case "список":
                    Console.WriteLine(s.GetGoods());
                    break;
                case "сохранить":
                    s.SaveList();
                    break;
                    default: Console.WriteLine("ошибка в команде");
                    break;


            }
        }
    }
}