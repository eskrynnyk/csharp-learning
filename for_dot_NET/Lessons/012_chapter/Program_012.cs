Console.OutputEncoding = System.Text.Encoding.UTF8;
// See https://aka.ms/new-console-template for more information


// Строгая типизация, объявление переменных
int age; // Объявление переменной типа int с именем age
double salary; // Объявление переменной типа double с именем salary
string name; // Объявление переменной типа string с именем name

// Присваивание значений
age = 30; // Присваивание значения 30 переменной age
salary = 0002500.50000; // Присваивание значения 2500.50 переменной salary
name = "John"; // Присваивание значения "John" переменной name

// Инициализация переменных
string productName = "Ноутбук";
char c = 'A';
double price = 1200.99;
int quantityInStock = 50;
productName = "Телефон";
string acumaticaOrderID = "SO0001";
int acumaticaOrderNbr = 101;

// Чувствительность к регистру
// productName - не равно ProductName
Console.WriteLine("Hello, World!");
Console.WriteLine("Какой-то текст");
Console.WriteLine("Наименование товара " + productName);
Console.WriteLine("Ценник " + price);
Console.WriteLine("Sales Order " + acumaticaOrderID + " equal " + acumaticaOrderNbr);

//Task
double x = 3;
double y = 4;
double z = 5;
double result = x * y * z;
Console.WriteLine(result);


Week today = Week.Mon;
Console.WriteLine("enum: " + today);

enum Week { Mon, Tue, Wed, Thu, Fri, Sat, Sun };