namespace RoboTupiniquim.ConsoleApp; 

internal class Program
{
    static int area;
    static int posicaox;
    static int posicaoy;
    static char direcao;
    static string instrucaoString;

    static void Main(string[] args)
    {
        Console.WriteLine("-- Robo Tupiniquim --");

        Console.WriteLine("Digite o tamanho da area: ");
        area = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a posição horizontal do robô: ");
        posicaox = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a posição vertical do robô: ");
        posicaoy = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a direção do robô: ");
        direcao = char.Parse(Console.ReadLine());

        Console.WriteLine("Digite A instrução para o robô(E, D, M): ");
        instrucaoString = Console.ReadLine();
        char[] instrucao = instrucaoString.ToCharArray();

        Console.WriteLine("Seu robô esta aqui:");
        MostrarPosicaoRobo(area, posicaox, posicaoy);

        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine();

        for (int i = 0; i < instrucao.Length; i++)
        {
            switch (instrucao[i]) 
            {
                case 'E':
                    VirarEsquerda();
                    break;
                case 'D':
                    VirarDireita();
                    break;
                case 'M':
                    Mover();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor insira uma opção válida!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
        }

        Console.WriteLine("Seu robô foi para: ");
        MostrarPosicaoRobo(area, posicaox, posicaoy);
    }

    static void Mover()
    {
        if(direcao == 'N')
        {
            posicaoy++;
        }
        else if (direcao == 'S')
        {
            posicaoy--;
        }
        else if(direcao == 'O')
        {
            posicaox--;
        }
        else if (direcao == 'L')
        {
            posicaox++;
        }
    }

    static void VirarEsquerda()
    {
        if (direcao == 'N')
        {
            direcao = 'O';
        }
        else if (direcao == 'O')
        {
            direcao = 'S';
        }
        else if (direcao == 'S')
        {
            direcao = 'L';
        }
        else if (direcao == 'L')
        {
            direcao = 'N';
        }
    }

    static void VirarDireita()
    {
        if (direcao == 'N')
        {
            direcao = 'L';
        }
        else if (direcao == 'O')
        {
            direcao = 'N';
        }
        else if (direcao == 'S')
        {
            direcao = 'O';
        }
        else if (direcao == 'L')
        {
            direcao = 'S';
        }
    }

    static void MostrarPosicaoRobo(int area, int coluna, int linha)
    {
        for (int i = 1; i <= area; i++)
        {
            for (int j = 1; j <= area; j++)
            {
                if (i == linha && j == coluna)
                {
                    Console.Write("x ");
                    continue;
                }
                Console.Write("_ ");
            }
            Console.WriteLine();
        }

        return;
    }
}
