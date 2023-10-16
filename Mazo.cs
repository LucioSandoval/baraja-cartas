public class Mazo{
    public List<Carta> Cartas { get; set; }

    public Mazo()
    {
        Cartas = new List<Carta>();
        InicializarMazo();
    }

    private void InicializarMazo()
    {
        string[] pintas = { "Corazones", "Diamantes", "Tréboles", "Picas" };

        foreach (var pinta in pintas)
        {
            for (int valor = 1; valor <= 13; valor++)
            {
                Carta carta = new Carta("", pinta, valor);
                switch (valor)
                {
                    case 1:
                        carta.Nombre = "As";
                        break;
                    case 11:
                        carta.Nombre = "J";
                        break;
                    case 12:
                        carta.Nombre = "Reina";
                        break;
                    case 13:
                        carta.Nombre = "Rey";
                        break;
                    default:
                        carta.Nombre = valor.ToString();
                        break;
                }
                Cartas.Add(carta);
            }
        }
    }

    public Carta RepartirCarta()
    {
        if (Cartas.Count == 0)
        {
            Console.WriteLine("El mazo está vacío. No se pueden repartir más cartas.");
            return null;
        }

        Carta cartaRepartida = Cartas[Cartas.Count - 1];
        Cartas.RemoveAt(Cartas.Count - 1);
        return cartaRepartida;
    }

    public void ReiniciarMazo()
    {
        Cartas.Clear();
        InicializarMazo();
    }

    public void Barajar()
    {
        Random rng = new Random();
        int n = Cartas.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Carta temp = Cartas[k];
            Cartas[k] = Cartas[n];
            Cartas[n] = temp;
        }
    }
    
}