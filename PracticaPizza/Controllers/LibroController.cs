using System.Collections.Generic;

public class PizzaController{

        private List<Pizza> pizzas = new List<Pizza>();

        public void AddPizza(string name, string size, float price){

            pizzas.Add(new Pizza{Name = name, Size =size, Price = price});

        }

        public List<Pizza> GetMenu(){
            return pizzas;
        }
}
