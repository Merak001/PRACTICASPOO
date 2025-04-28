using System;

public class CarController
{

    private List<Car> cars = new List<Car>();
    public void AddCarr(string marca, string modelo, int anio){

        cars.Add(new Car{Marca = marca, Modelo = modelo, Anio = anio});
        }

    public List<Car> GetCars(){
        return cars;
    }

}