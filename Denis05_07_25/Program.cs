using System;
using System.Threading.Channels;

// компʼютер та його компоненти 

// Computer - головний клас, який поєднує всі інші 
// Processor, Memory, Storage - створюється всередині Computer - *композиція 
// Keyboard, Monitor - передаєтсья ззовні - *агрегація 
// User - користується Computer - *асоціація  
// метод InstallSoftwate(Software soft) - залежність


class Computer
{
    private void 
}

class Processor
{
    public void ProcessData()
    {
        Console.WriteLine($"Process get started...");
    }
}

class Memory
{
    public void LoadData()
    {
        Console.WriteLine($"*Loading*");
    }
}

class Storage
{
    public void SaveData()
    {
        Console.WriteLine($"*Saving*");
    }
}

class Keyboard
{
    public void Typing(string text)
    {
        Console.WriteLine($"You typing {text}...");
    }
}

class Monitor
{
    public void Display(string textOnTheString)
    {
        Console.WriteLine($"{textOnTheString} on the screen");
    }
}

class User
{

}

class Software
{
    public string name { get; set; }
}