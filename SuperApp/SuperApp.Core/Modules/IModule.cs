namespace SuperApp.Core.Modules;

public interface IModule
{
    string Name { get; }
    void Register();
    void ShowMenu();
}

