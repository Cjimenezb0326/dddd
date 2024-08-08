using System;
using System.Collections.Generic;

class Dispositivo
{
    public string Nombre { get; set; }
    public string Marca { get; set; }

    public Dispositivo(string nombre, string marca)
    {
        Nombre = nombre;
        Marca = marca;
    }

    public virtual void mostrar_info()
    {
        Console.WriteLine($"Nombre: {Nombre}, Marca: {Marca}");
    }
}

class Electronico : Dispositivo
{
    public string Año_de_lanzamiento { get; set; }

    public Electronico(string nombre, string marca, string año) : base(nombre, marca)
    {
        Año_de_lanzamiento = año;
    }

    public override void mostrar_info()
    {
        base.mostrar_info();
        Console.WriteLine($"Año de lanzamiento: {Año_de_lanzamiento}");
    }
}

class Smartwatch : Electronico
{
    private List<string> funciones;

    public Smartwatch(string nombre, string marca, string año, List<string> funciones)
        : base(nombre, marca, año)
    {
        this.funciones = funciones;
    }

    public override void mostrar_info()
    {
        base.mostrar_info();
        Console.WriteLine("Funciones:");
        foreach (var funcion in funciones)
        {
            Console.WriteLine($"- {funcion}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dispositivo iphone = new Electronico("iPhone", "Apple", "2023");
        Dispositivo tablet = new Electronico("Galaxy Tab", "Samsung", "2022");
        Smartwatch appleWatch = new Smartwatch("Apple Watch", "Apple", "2023", new List<string> { "Monitor de ritmo cardíaco", "GPS", "Resistente al agua" });

        Console.WriteLine("Información de iPhone:");
        iphone.mostrar_info();
        Console.WriteLine();

        Console.WriteLine("Información de Galaxy Tab:");
        tablet.mostrar_info();
        Console.WriteLine();

        Console.WriteLine("Información de Apple Watch:");
        appleWatch.mostrar_info();
    }
}
