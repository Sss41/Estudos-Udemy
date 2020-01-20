using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercicioMatriz();
        }
        public static void Exercicio1()
        {

            Console.WriteLine("Insira um número inteiro");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Número par:" + i);
                }
            }
        }
        public static void Exercicio2()
        {
            Console.WriteLine("Entre com valor inteiro:");
            int n = int.Parse(Console.ReadLine());


            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Insira o valor de x");
                int x = int.Parse(Console.ReadLine());
                if (x <= 20 && x >= 10)
                {
                    dentro = dentro + 1;
                }
                else
                {
                    fora = fora + 1;
                }

            }
            Console.WriteLine("Numeros que estão dentro do intervalo de 10 a 20 " + dentro);
            Console.WriteLine("Numeros que estão fora do intervalo de 10 a 20 " + fora);
        }
        public static void Exercicio3()
        {

            Console.WriteLine(" Insira valor inteiro:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dicite tres números reais separodos por espaço:");
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5) / 10;
                Console.WriteLine("Média igual :" + media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
        public static void Exercicio4()
        {
            var gasolina = 0;
            var diesel = 0;
            var alcool = 0;

            Console.WriteLine("Informe o código do combustivel");
            int tipoCombustivel = int.Parse(Console.ReadLine());

            while (tipoCombustivel != 4)
            {
                if (tipoCombustivel == 1)
                {
                    alcool = gasolina + 1;
                }
                else if (tipoCombustivel == 2)
                {
                    gasolina = alcool + 1;
                }
                else if (tipoCombustivel == 3)
                {
                    diesel = diesel + 1;
                }

                Console.WriteLine("Informe o código do combustivel");
                tipoCombustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Muito obrigado");
        }
        public static void Exercicio5()
        {
            Console.WriteLine("Insira um número inteiro!");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);

                if (b == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double divisao = (double)a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
        public static void Exercicio6()
        {
            Console.WriteLine("Digite um número");
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine("O número é:" + fatorial);
        }

        public static void Exercicio7()
        {
            Console.WriteLine("Digite um número interio:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("Os divisores são:" + i);
            }
        }

        public static void Exercicio8()
        {
            Console.WriteLine("Insira um número inteiro e positivo:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiroNumero = i;
                int segundoNumero = i * i;
                int terceiroNumero = i * i * i;
                Console.WriteLine($"Os números são: {primeiroNumero}  {segundoNumero} {terceiroNumero}");
            }
        }

        public static void Exercicio9()
        {
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Digite as informações da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite as informaões da segunda pessoa:");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = int.Parse(Console.ReadLine());
            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + primeiraPessoa.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + segundaPessoa.Nome);
            }
        }

        public static void Exercicio10()
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Insira os dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira os dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double mediaSalarial = (funcionario1.Salario + funcionario2.Salario) / 2.0;
            Console.WriteLine("A média Salarial é:" + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Exercicio11()
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Digite a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Exercicio12()
        {
            Funcionariio funcionariio = new Funcionariio();
            Console.Write("Nome: ");
            funcionariio.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionariio.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionariio.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionariio);

            Console.WriteLine();
            Console.Write("Quer aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionariio.AumentoDeSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Esses são os dados atualizados: " + funcionariio);
        }

        public static void Exercicio13()
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Insira as três notas do aluno:");
            aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota final= "
            + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " Pontos");
            }
        }

        public static void Exercicio14()
        {
            Console.WriteLine("Qual a cotação do dolar? ");
            double coatacaoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qantos dolares você gostaria de comprar?");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorMoeda.DolarReal(quantidade, coatacaoDoDolar);
            Console.WriteLine("Valor para pagamento em reais" + quantidade.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ExercicioFixacaoo()
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resultado = char.Parse(Console.ReadLine());
            if (resultado == 's' || resultado == 'S')
            {
                Console.Write("Digite o valor para depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write(" Digite um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write(" Digite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
        public static void ExercicioFixacaoo1()
        {
            Ponteiro ponteiro;
            ponteiro.x = 10;
            ponteiro.y = 20;
            Console.WriteLine(ponteiro);
            ponteiro = new Ponteiro();
            Console.WriteLine(ponteiro);
        }
        public static void ExercicioVetor()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            double media = soma / n;
            Console.WriteLine("altura media igual:" + media.ToString("F2"), CultureInfo.InvariantCulture);
        }

        public static void ExercicioVetor2()
        {
            int n = int.Parse(Console.ReadLine());
            Produto[] vet = new Produto[n];
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto { Nome = nome, Preco = preco };
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;

            }
            double media = soma / n;
            Console.WriteLine("O preço médio igual:" + media.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void ExercicioVetor3()
        {
            Console.Write("Quantos quartos serão reservados?");
            int n = int.Parse(Console.ReadLine());
            Estudantes[] grupoDeEstudantes = new Estudantes[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Qual o nome para reserva?");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o email para reserva?");
                string email = Console.ReadLine();
                Console.WriteLine("Qual o número do quarto para reserva?");
                int quartos = int.Parse(Console.ReadLine());

                grupoDeEstudantes[quartos] = new Estudantes { Nome = nome, Email = email };

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informções da reserva!");
                if (grupoDeEstudantes[i] != null)
                {
                    Console.WriteLine(i + " Quarto reservado: " + grupoDeEstudantes[i]);
                }
            }

        }
        public static void ExercicioParametros1()
        {
            int s1 = Calculadora.Soma(2, 3);
            int s2 = Calculadora.Soma(2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }

        public static void ExercicioParametros2()
        {
            int a = 10;
            SegundaCalculadora.Triplicar(ref a);
            Console.WriteLine(a);
        }

        public static void ExercicioParametros3()
        {
            int a = 10;
            int triplicarNumero;
            TerceiraCalculadora.TriplicarNumero(a, out triplicarNumero);
            Console.WriteLine(triplicarNumero);
        }

        public static void ExercicioListas()
        {
            List<string> list = new List<string>();
            list.Add("Ana");
            list.Add("Alex");
            list.Add("Bob");
            list.Insert(2, "Mario");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Conatador da lista" + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'A');
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------");
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("alex");
            Console.WriteLine("--------------------------------");
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void ExercicioListas1()
        {

            Console.Write("Quantos funcionários estão registrados ? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Insira o Id do funcionário para aumento de salário : ");
            int procurar = int.Parse(Console.ReadLine());

            Funcionarios item = list.Find(x => x.Id == procurar);
            if (item != null)
            {
                Console.Write("Insira porcentageme: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                item.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");
            foreach (Funcionarios item1 in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void ExercicioMatriz()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");
            for( int i = 0; i< n; i++)
            {
                Console.Write(mat[i,i] +  " ");
            }
            Console.WriteLine();

            int contagem = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contagem++;
                    }
                }
            }
            Console.WriteLine("numeros negativos: " + contagem);
        }

        public static void Conjuntos()
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3); 
            B.Add(4); 
            B.Add(5);

            foreach(int x in A)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());
            if (A.Contains(N))
            {
                Console.WriteLine(N + "pertence ao conjunto A");
            }
            else
            {
                Console.WriteLine("Não pertence ao conjunto A");
            }

            Console.ReadLine();
        }
    }
}