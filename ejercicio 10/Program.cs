using System;

class programm
{
    static void Main(string[] args)
    {
        /*Un restaurante ofrece un descuento del 10% para consumosde hasta
        S/ 100.00 y un descuento de 20% para consumosmayores de S/ 100.00,
        para ambos casos se aplica unimpuesto del 18%.• Determinar el monto
       del descuento, el impuesto, el sub total yel importe a pagar*/

        double pd,sb,im,ip;

        Console.WriteLine("Cuanto piensas consumir");
        double consumo= double.Parse(Console.ReadLine());

        if(consumo <=100 ) {
            pd = 0.10*consumo;

        }
        else {
            pd = 0.20*consumo;
        }
        sb = consumo - pd;
        im = sb * 0.18;
        ip = im + sb;
        Console.WriteLine("Monto del descuento: S/ " + pd);
        Console.WriteLine("Impuesto: S/ " + im);
        Console.WriteLine("Subtotal: S/ " + sb);
        Console.WriteLine("Importe a pagar: S/ " + ip);






    }


}