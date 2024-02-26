namespace VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //questão 1
            Console.Write("Qual a largura: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Qual o comprimento: ");
            double comprimento = double.Parse(Console.ReadLine());

            double calculo = largura * comprimento;

            Console.WriteLine($"A área é de {calculo.ToString("F2")} m²");
            
            //questão 2
            int calculo, cavalos;
            Console.WriteLine("Quantos cavalos iram por a ferradura ?");
            
            cavalos = int.Parse(Console.ReadLine());

            calculo = cavalos * 4;
            
            Console.Write($"A quantidade de ferraduras necessárias é: {calculo}");

            //questão 3

            Console.Write("Quantos anos você tem: ");
            int idadeUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine($"JÁ VIVEU {idadeUsuario*365} DIAS.");

            //questão 4

            Console.WriteLine("Informe o preço do litro da gasolina:");
            double precoLitro = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do pagamento:");
            double valorPagamento = double.Parse(Console.ReadLine());

            double litrosAbastecidos = valorPagamento / precoLitro;

            Console.WriteLine($"Com R${valorPagamento.ToString("F2")}, o motorista conseguiu abastecer {litrosAbastecidos.ToString("F2")} litros de gasolina.");
            
            //questão 5
            int pequeno, medio, grande, calculo;
            Console.WriteLine("Escreva a quantidade da peça de roupa: pequena, médio e grande.\nConsecutivamente e sepadas SOMENTE por expaço. Ex: 5 6 7");
            string[] todasRoupas = Console.ReadLine().Split(' ');

            pequeno = int.Parse(todasRoupas[0]);
            medio = int.Parse(todasRoupas[1]);
            grande = int.Parse(todasRoupas[2]);

            calculo = pequeno * 10 + medio * 12 + grande * 15;

            Console.WriteLine($"O valor total: {calculo} reis");

            Console.WriteLine($"O total em ml: {total} ml");

            Console.WriteLine($"O tatal em Litros: {total / 1000}");


            //questão 6

            double salarioOriginal,salarioAumento,salarioDesconto;

            double imposto = 0.08;
            double aumento = 0.15;

            Console.WriteLine("Qual o seu salário?");
            salarioOriginal = double.Parse(Console.ReadLine());

            salarioAumento = (salarioOriginal * aumento) + salarioOriginal;
            salarioDesconto = ((salarioAumento * imposto) - salarioAumento)*-1;

            Console.WriteLine($"Seu salário inicial: {salarioOriginal}");
            Console.WriteLine($"Seu salário com aumento: {salarioAumento}");
            Console.WriteLine($"Seu salário com imposto: {salarioDesconto.ToString("F2")}");
            

            //questão 7
            double raio, altura, calculo;
            double PI = 3.14;

            Console.Write("Escreva o raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Escreva a altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calculo = PI * ((Math.Pow(raio, 2) * altura));

            Console.WriteLine($"O valor do volume é: {calculo.ToString("F1", CultureInfo.InvariantCulture)} cm\u00B3");
            
            
            //questão 9
            double valorMetros = int.Parse(Console.ReadLine());


            for (int i = 0; i <= 2; i++)
            {

                double controle = valorMetros;

                if (i == 0)
                {
                    valorMetros = valorMetros * 100;
                    Console.WriteLine($"M para Cm: {valorMetros}");
                    valorMetros = controle;
                }
                else if (i == 1)
                {
                    valorMetros = valorMetros * 1000;
                    Console.WriteLine($"M para Mm: {valorMetros}");
                    valorMetros = controle;

                }
                else
                {
                    valorMetros = valorMetros / 1000;
                    Console.WriteLine($"M para Km: {valorMetros}");
                    valorMetros = controle;

                }
            }
            

            //questão 10
            double lataML, garrafaML, garrafaL, total;

            Console.Write("Quantas latas de 350 ml: ");
            lataML = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantas garrafas de 600ml: ");
            garrafaML = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantas garrafas de 2 litros: ");
            garrafaL = Convert.ToDouble(Console.ReadLine());

            total = (350 * lataML) + (600 * garrafaML) + (garrafaL * 2000);

            */
        }
    }
}

