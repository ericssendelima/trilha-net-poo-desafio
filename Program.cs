using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new(numero: "81912344321", modelo: "motorola", imei: "dijsljlsdjf", memoria: 100);
iphone.Ligar();
iphone.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

Console.WriteLine("Smartphone nokia: ");
Nokia nokia = new(numero: "81998766543", modelo: "acer", imei: "smdnfmsdfsdfds", memoria: 500);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("VsCodeMobile");