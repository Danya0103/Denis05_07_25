using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

// компʼютер та його компоненти 

// Computer - головний клас, який поєднує всі інші 
// Processor, Memory, Storage - створюється всередині Computer - *композиція 
// Keyboard, Monitor - передаєтсья ззовні - *агрегація 
// User - користується Computer - *асоціація  
// метод InstallSoftwate(Software soft) - залежність


class Computer {

    // Поля під композицію
    private Processor processor;
    private Memory memory;
    private Storage storage;


    // Поля під агрегацію
    private Keyboard keyboard;
    private Monitor monitor;

    public List<Software> Games { get; private set; } 
    public Computer(Keyboard keyboard, Monitor monitor) {

        processor = new Processor();
        memory = new Memory();
        storage = new Storage();

        this.keyboard = keyboard;
        this.monitor = monitor;

        Games = new List<Software>();


    }

    public void Start()
    {
        memory.LoadData();
        processor.ProcessData();
        storage.SaveData();
        monitor.Display($"Enter password: ");
        keyboard.Typing($"1234");

    }
     public void InstallSoftwate(Software soft) {

        Games.Add(soft);
        monitor.Display($"Program insttaled: {soft.name}");

    }

}

class Processor {

    public void ProcessData() {

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

class User {

    public string name { get; set; }
    public void useComputer(Computer computer) {

        Console.WriteLine($"{name} work in computer");
        computer.Start();

    }
}

class Software {

    public string name { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        
    }
}