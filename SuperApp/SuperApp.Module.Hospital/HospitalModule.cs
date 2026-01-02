using SuperApp.Core.Modules;
namespace SuperApp.Module.Hospital;


public class HospitalModule : IModule
{
    public string Name => "Hospital";
    public void Register(){}
    public void ShowMenu()
    {
        Console.WriteLine("==== Wellcome to the Hospital Module ====");
        Console.WriteLine("[1]- Add hospital");
        Console.WriteLine("[2]- Show hospitals");
        Console.WriteLine("[3]- Show Personels Panel"); 
        Console.WriteLine("[4]- "); 
    }
}