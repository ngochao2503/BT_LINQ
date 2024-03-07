// See https://aka.ms/new-console-template for more information
using BT_LINQ;

Console.WriteLine("Hello, World!");

List<Car> cars = new List<Car>()
{
    new Car("Toyota", 2020, 150000, 5, "Trang", "Tu dong", "Xang", 1.5),
    new Car("Honda", 2021, 260000, 4, "Đen", "So san", "Hybrid", 1.8),
    new Car("Ford", 2018, 180000, 5, "Xam", "Tu đong", "Xang", 2.0),
    new Car("Mazda", 2019, 240000, 5, "Đo", "Tu đong", "Dau", 2.5),
    new Car("Toyota", 1999, 90000, 6, "Trang", "Tu đong", "Xang", 1.5),
    new Car("Honda", 2015, 180000, 8, "Xanh", "So san", "Hybrid", 1.8),
    new Car("Ford", 2011, 120000, 4, "vang", "Tu dong", "Xang", 2.0),
    new Car("Mazda", 1989, 70000, 4, "Hong", "Tu đong", "Xang", 1.0),
};
Console.WriteLine("Xe có gia tu 100.000 đen 250.000");
Console.ReadKey();
foreach(var car in cars.Where(c => c.Price >= 100000 && c.Price <= 250000))
{
    Console.WriteLine(car.ToString());
}
Console.WriteLine("Hien thi cac xe co nam san xuat > 1990");
Console.ReadKey();
foreach (var car in cars.Where(c => c.Year > 1990))
{
    Console.WriteLine(car.ToString());
}
Console.WriteLine("Cac xe theo hang sx:");
Console.ReadKey();
var carGroups = cars.GroupBy(c => c.Make);
foreach(var group in carGroups)
{
    Console.WriteLine($"**Hang: {group.Key}**");
    Console.WriteLine($"Tong gia tri: {group.Sum(c => c.Price)}");
}


List<Truck> trucks = new List<Truck>()
{
    new Truck("Toyota", 2022, 300000, 10, "Thung lung", 5.5), // thùng lửng
    new Truck("Hino", 2020, 250000, 15, "Thung kin", 6.2), // thùng kín
    new Truck("Isuzu", 2019, 280000, 12, "Bung nang", 4.8),
    new Truck("Toyota", 2018, 200000, 15, "Thung lung", 5.5),
    new Truck("Hino", 2001, 150000, 15, "Thung kin", 6.2),
    new Truck("Isuzu", 2010, 220000, 10, "Bung nang", 4.8), //Bửng nâng
};

Console.WriteLine("**Danh sach Truck theo thu tu nam sx moi nhat:**");
Console.ReadKey();
foreach (var truck in trucks.OrderByDescending(t => t.Year))
{
    Console.WriteLine(truck.ToString());
}
Console.WriteLine("**Ten cty chu quan cua Truck: **");
Console.ReadKey();
foreach (var truck in trucks)
{
    string companyName = GetCompanyName(truck.Make);
    Console.WriteLine($"{truck.Make} - {companyName}");
}
Console.ReadKey();
string GetCompanyName(string make)
{
    switch (make)
    {
        case "Toyota":
            return "Toyota Motor Corporation";
        case "Hino":
            return "Hino Motors, Ltd.";
        case "Isuzu":
            return "Isuzu Motors Limited";
        default:
            return "Unknown";
    }
}


