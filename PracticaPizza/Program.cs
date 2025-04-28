using System;

class ProgramPizza{

    static void Main(string[] args)
    {
        PizzaController pizzasMenu = new PizzaController();

        for(int i=0; i<3;i++){
            Console.WriteLine($"Ingresa el nombre de la pizza {i + 1}");
             string pizzaName = Console.ReadLine();

            Console.WriteLine($"Ingresa el tamaño de la pizza {i + 1}");
            string pizzaSize = Console.ReadLine();

            Console.WriteLine($"Ingresa el precio de la pizza {i + 1}");
            int pizzaPrice = int.Parse(Console.ReadLine());

            pizzasMenu.AddPizza(pizzaName,pizzaSize,pizzaPrice);
        }

        var menu =  pizzasMenu.GetMenu();
        foreach(var pizza in menu){
            Console.WriteLine($"Pizza la: {pizza.Name}");
            Console.WriteLine($"Tamño de la pizza: {pizza.Size}");
            Console.WriteLine($"Precio de la pizza: {pizza.Price}");
            Console.WriteLine("-----------------");
        }

        
    }
}