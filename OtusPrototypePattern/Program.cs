// See https://aka.ms/new-console-template for more information
using OtusPrototypePattern.Models;

//Test ICloneable
House house = new()
{
    Address = "Казань",
    Cost = 700,
    NumberOfResidents = 4
};
WoodenHouse woodenHouse = new()
{
    Address = "Москва",
    Cost = 800,
    NumberOfResidents = 2,
    MaxFloor = 2
};
BrickHouse brickHouse = new()
{
    Address = "Санкт-Питербург",
    Cost = 1000,
    NumberOfResidents = 5,
    MaxFloor = 3
};
Console.WriteLine("ICloneable test:");
house.GettingOld();
woodenHouse.GettingOld();
brickHouse.GettingOld();

var houseClone = (House)house.MyClone();
var woodenHouseClone = (WoodenHouse)woodenHouse.Clone();
var brickHouseClone = (BrickHouse)brickHouse.Clone();

Console.WriteLine($"The condition of House: {houseClone.Condition}");
Console.WriteLine($"The condition of WoodenHouseClone: {woodenHouseClone.Condition}");
Console.WriteLine($"The condition of BrickHouseClone: {brickHouseClone.Condition}");
Console.WriteLine("");
Console.WriteLine("");



//Test IMyCloneable
House house2 = new()
{
    Address = "Казань",
    Cost = 700,
    NumberOfResidents = 4
};
WoodenHouse woodenHouse2 = new()
{
    Address = "Москва",
    Cost = 800,
    NumberOfResidents = 2,
    MaxFloor = 2
};
BrickHouse brickHouse2 = new()
{
    Address = "Санкт-Питербург",
    Cost = 1000,
    NumberOfResidents = 5,
    MaxFloor = 3
};
Console.WriteLine("IMyCloneable test:");

house2.GettingOld();
woodenHouse2.GettingOld();
brickHouse2.GettingOld();

var houseClone2 = (House)house2.MyClone();
var woodenHouseClone2 = (WoodenHouse)woodenHouse2.MyClone();
var brickHouseClone2 = (BrickHouse)brickHouse2.MyClone();

Console.WriteLine($"The condition of House2: {houseClone2.Condition}");
Console.WriteLine($"The condition of WoodenHouseClone2: {woodenHouseClone2.Condition}");
Console.WriteLine($"The condition of BrickHouseClone2: {brickHouseClone2.Condition}");
Console.WriteLine("");
Console.WriteLine("");