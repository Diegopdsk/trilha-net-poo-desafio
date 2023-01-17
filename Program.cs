using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Informações do Celular Nokia");
Nokia nokia = new Nokia("985223236", "1100", "12345632", 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhattsApp");
nokia.ReceberLigacao();

Console.WriteLine("________________________________________________________");

Console.WriteLine("Informações do Celular Iphone");
Iphone iphone = new Iphone("999175485", "6S", "33366985", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
