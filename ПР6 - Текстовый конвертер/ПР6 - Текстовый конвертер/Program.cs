namespace ПР6___Текстовый_конвектор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string path = menu1();
                ConsoleKeyInfo key = menu2(path);
                if (key.Key == ConsoleKey.Escape) { break; }
                if (key.Key == ConsoleKey.F1)
                {
                    menu3();
                }
            }
        }
        static string menu1()
        {

            Console.WriteLine("===============================================");
            Console.WriteLine("Введите путь до файла,который хотите открыть.");
            Console.WriteLine("===============================================");
            string path = Console.ReadLine();
            Console.Clear();
            return path;
        }
        static ConsoleKeyInfo menu2(string path)
        {
            ConsoleKeyInfo key;
            while (true)
            {
                Console.WriteLine("=====================================================================");
                Console.WriteLine("Сохранить файл в формате txt или json или xml - F1. Выход - Escape.");
                Console.WriteLine("=====================================================================");
                if (path.Contains(".txt")) { Figure.txt_open(path); }
                if (path.Contains(".json")) { Figure.json_open(path); }
                if (path.Contains(".xml")) { Figure.xml_open(path); }
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape | key.Key == ConsoleKey.F1) { break; }
                Console.Clear();
            }
            Console.Clear();
            return key;
        }
        static void menu3()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("Введите путь до файла, куда хотите сохранить текст.");
            Console.WriteLine("=====================================================");
            string path = Console.ReadLine();
            if (path.Contains(".txt")) { Figure.txt_save(path); }
            if (path.Contains(".json")) { Figure.json_save(path); }
            if (path.Contains(".xml")) { Figure.xml_save(path); }
            Console.Clear();
        }
    }
}