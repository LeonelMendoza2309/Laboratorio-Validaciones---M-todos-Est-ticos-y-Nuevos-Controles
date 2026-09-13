using System;

public class Craps
{
    private Random NumAleatorio = new Random();

    private enum Estado { CONTINUAR, GANAR, PERDER }

    private enum NombDados
    {
        DOS_UNOS = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12
    }

    public void Jugar()
    {
        Estado estadoJuego = Estado.CONTINUAR;

        int miPunto = 0;

        int sumaDeDados = TirarDados();

        switch((NombDados)sumaDeDados)
        {
            case NombDados.SIETE:
            case NombDados.ONCE:
                estadoJuego = Estado.GANAR;
                break;
            case NombDados.DOS_UNOS:
            case NombDados.TRES:
            case NombDados.DOCE:
                estadoJuego = Estado.PERDER;
                break;
            default:
                estadoJuego = Estado.CONTINUAR;
                miPunto = sumaDeDados;
                Console.WriteLine("El punto es {0}", miPunto);
                break;
        }

        while (estadoJuego == Estado.CONTINUAR)
        {
            sumaDeDados = TirarDados();
            if (sumaDeDados == miPunto)
            {
                estadoJuego = Estado.GANAR;
            }
            else if (sumaDeDados == (int)NombDados.SIETE)
            {
                estadoJuego = Estado.PERDER;
            }
        }

        if(estadoJuego == Estado.GANAR)
        {
            Console.WriteLine("JUGADOR GANOO");
        }
        else
        {
            Console.WriteLine("JUGADOR PERDIO");
        }
    }

    public int TirarDados()
    {
        int dad1 = NumAleatorio.Next(1, 7);
        int dad2 = NumAleatorio.Next(1, 7);

        int sum = dad1 + dad2;

        Console.WriteLine("Jugador tiró {0} + {1} = {2}", dad1, dad2, sum);
        return sum;
    }
}
