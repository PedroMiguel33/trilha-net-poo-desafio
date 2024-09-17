using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia(numero: "87654321", modelo: "Tijolão", imei: "559185125", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("SmartPhone iPhone");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "iPhone 16 Ultra Pro Max Plus", imei: "712465161", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");