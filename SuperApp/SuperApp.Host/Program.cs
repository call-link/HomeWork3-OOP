using SuperApp.Core.Modules;
using SuperApp.Module.Library;
using SuperApp.Module.Hospital;


class Program
{
    static void Main()
    {
        List<IModule> modules = new()
        {
            new LibraryModule(),
            new HospitalModule()
            
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Super App ===");

            for (int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {modules[i].Name}");
            }
            Console.WriteLine("Please Select a option ...");
            var input = Console.ReadLine();
            var index = int.Parse(input) - 1;

            modules[index].ShowMenu();
        }
    }
}
