using SuperApp.Core.Modules;
using SuperApp.Module.Library;

class Program
{
    static void Main()
    {
        List<IModule> modules = new()
        {
            new LibraryModule()
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Super App ===");

            for (int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {modules[i].Name}");
            }

            var input = Console.ReadLine();
            var index = int.Parse(input) - 1;

            modules[index].ShowMenu();
        }
    }
}
