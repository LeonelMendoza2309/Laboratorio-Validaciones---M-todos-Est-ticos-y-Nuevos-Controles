 public class PruebaCraps
 {
    public static void Main(string[] args)
 {
    Craps juego = new Craps();
        Console.WriteLine("Bienvenido al juego de dados, presiona enter para comenzar...");
        Console.ReadKey();  
        juego.Jugar(); 
 } 
} 