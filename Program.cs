using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "112233", imei: "9876543210", modelo: "1100", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("GitHub");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "654321", imei: "1234567890", modelo: "15", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("DIO");