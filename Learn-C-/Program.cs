// Application to count sisi miring segitiga siku2

Console.WriteLine("Masukkan nilai sisi tegak: ");
double sisiTegak = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Masukkan nilai sisi mendatar: ");
double sisiMendatar = Convert.ToDouble(Console.ReadLine());

double sisiMiring = Math.Sqrt(sisiTegak * sisiTegak + sisiMendatar * sisiMendatar);
Console.WriteLine("Sisi miring segitiga yaitu: ");
Console.WriteLine(sisiMiring);