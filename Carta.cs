public class Carta{
    public string Nombre { get; set; } //(As, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Reina, Rey). 
    public string Pinta { get; set; } //(Tréboles, Picas, Corazones, Diamantes).​
    public int Val {get; set;} // valor numérico de la tarjeta (1-13) como enteros.​


    public Carta()
    {
        // Constructor por defecto
    }

    public Carta( string nombre, string pinta, int val){
        this.Nombre = nombre;
        this.Pinta = pinta;
        this.Val = val;
    }
    public void Print()
    {
        Console.WriteLine($"Carta: {Nombre} de {Pinta}, Valor: {Val}");
    }
}