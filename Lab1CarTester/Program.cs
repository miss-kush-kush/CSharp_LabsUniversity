using static System.Console;

using CarTester;
List<Car> cars = new();
cars.Add(new PetrolCar());
cars.Add(new GasCar());
cars.Add(new ElectricCar());

foreach (Car car in cars)
{
    RideTester(car);
}

static void RideTester(Car car)
{
    WriteLine("Beginning of driving test :\n");
    car.ReFuel();
    car.ReFuel();
    car.Run();
    car.Start();
    car.Start();
    car.Run();
    car.Run();
    car.Stop();
    car.Stop();
    WriteLine("End of driving test ;\n");
}