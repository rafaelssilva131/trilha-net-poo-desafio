using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Nokia("9123456789", "Modelo Nokia", "987654321", 124);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Smartphone iphone = new Iphone("9123456789", "Modelo Iphone", "123456789", 64);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
        }
    }
}