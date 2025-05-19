using DesafioPOO.Models;

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Nokia:");
Nokia nokia = new Nokia("123456789", "Modelo Nokia", "123456789012345", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("----------------------------------------------");

Console.WriteLine("\n");

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Iphone:");
Iphone iphone = new Iphone("987654321", "Modelo iPhone", "987654321098765", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Console.WriteLine("----------------------------------------------");