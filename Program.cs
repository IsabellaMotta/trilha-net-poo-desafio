using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Testes com o smartphone da Nokia: ");
Smartphone novoNokia = new Nokia(numero: "11912345678", modelo: "1", imei: "12345", memoria: 1024);
novoNokia.Ligar();
novoNokia.InstalarAplicativo("Instagram");
novoNokia.InstalarAplicativo("LinkedIn");
novoNokia.InstalarAplicativo("Canva");

//Pulando linha para ficar bonitinho no console
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Testes com o smartphone da Apple: ");
Smartphone novoIphone = new Iphone(numero: "11987654321", modelo: "iPhone 15 Pro Max", imei: "54321", memoria: 256);
novoIphone.Ligar();
Console.WriteLine($"O numero do novo iPhone é {novoIphone.Numero}");
novoIphone.InstalarAplicativo("Instagram");
novoIphone.InstalarAplicativo("LinkedIn");
novoIphone.InstalarAplicativo("Canva");