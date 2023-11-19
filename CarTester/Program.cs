using static System.Console;
using CarTester.Interfaces;
using CarTester.Normal;
using CarTester.Hybrids;

List<ICar> cars = new List<ICar>
            {
                new GasCar(),
                new ElectricCar(),
                new PetrolCar(),
                new PetrolGasCar(),
                new PetrolElectricCar(),
                new GasElectricCar()
            };

foreach (var car in cars)
{
    RideTester(car);
    WriteLine();
}

static void RideTester(ICar car)
{
    WriteLine("Beginning of driving test :\n");
    car.Refuel();
    car.Refuel();
    car.Run();
    car.Start();
    car.Start();
    car.Run();
    car.Run();
    car.Stop();
    car.Stop();
    WriteLine("End of driving test ;\n");
}