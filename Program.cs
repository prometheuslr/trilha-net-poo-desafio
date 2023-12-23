using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Modelo 10", "222222222", 120);

nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("6565656", "Modelo 24", "4444444", 64);
iphone.Ligar();
iphone.InstalarAplicativo("YouTube");