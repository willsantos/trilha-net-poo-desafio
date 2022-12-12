using DesafioPOO.Models;

var smart1 = new Nokia("11999990000",2,"21321321343452","Tijolão");

var smart2 = new Iphone("11988881111",32,"F2DA2393","Max Pro");

smart1.Ligar();
smart2.Ligar();

smart1.ReceberLigacao();
smart2.ReceberLigacao();

smart1.InstalarAplicativo("jogo da cobrinha");
smart2.InstalarAplicativo("Photoshop");

