
public class Program
{
    static void Main()
    {
        Mazo mazo = new Mazo();
        Jugador jugador = new Jugador("Jugador 1");

        Console.WriteLine("Baraja inicial:");
        ImprimirBaraja(mazo);

        Console.WriteLine("Repartir tres cartas al jugador:");
        for (int i = 0; i < 3; i++)
        {
            Carta carta = jugador.RobarCarta(mazo);
            if (carta != null)
                carta.Print();
        }

        Console.WriteLine("Mano del jugador:");
        ImprimirMano(jugador);

        Console.WriteLine("Descartar la primera carta del jugador:");
        Carta cartaDescartada = jugador.DescartarCarta(0);
        if (cartaDescartada != null)
        {
            cartaDescartada.Print();
            Console.WriteLine("Mano del jugador después de descartar:");
            ImprimirMano(jugador);
        }
    }

    static void ImprimirBaraja(Mazo mazo)
    {
        foreach (Carta carta in mazo.Cartas)
        {
            carta.Print();
        }
        Console.WriteLine($"Total de cartas en el mazo: {mazo.Cartas.Count}");
    }

    static void ImprimirMano(Jugador jugador)
    {
        foreach (Carta carta in jugador.Mano)
        {
            carta.Print();
        }
    }
}
