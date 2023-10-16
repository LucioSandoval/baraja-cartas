class Jugador
{
    public string Nombre { get; set; }
    public List<Carta> Mano { get; private set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        Mano = new List<Carta>();
    }

    public Carta RobarCarta(Mazo mazo)
    {
        Carta cartaRobada = mazo.RepartirCarta();
        if (cartaRobada != null)
        {
            Mano.Add(cartaRobada);
        }
        return cartaRobada;
    }

    public Carta DescartarCarta(int indice)
    {
        if (indice >= 0 && indice < Mano.Count)
        {
            Carta cartaDescartada = Mano[indice];
            Mano.RemoveAt(indice);
            return cartaDescartada;
        }
        return null;
    }
}