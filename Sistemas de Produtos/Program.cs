using System;

namespace Sistemas_de_Produtos
{
    class Program
    {
        static int tamanhoArrey = 2;
        static int tamanhoCopia = 0;
       
        static string[] nome = new string[tamanhoArrey];
        static double[] valor = new double[tamanhoArrey];
        static string promocao ;
        static int i2 = 0;
        static string novoCadastro = "s";
        
        static bool[] temPromocao = new bool[tamanhoArrey];
       
     
        
        static void Main(string[] args)
        {
            // int numeroProdutos;

            int menu;


            Console.WriteLine("Bem vindo :)");
            bool senhaErrada = false;
            do
            {


                Console.WriteLine("Para ver o menu digite m:");
                string verMenu = Console.ReadLine().ToLower();

                if (verMenu == "m")
                {
                    do
                    {

                        MostrarMenu();

                        menu = int.Parse(Console.ReadLine());

                        if (menu == 1)
                        {
                            CadastrarProduto();
                        }
                        if (menu == 2)
                        {
                            ListarProdutos();
                        }
                        if (menu == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Operação finalizada! OBRIGADO!");
                        }
                    } while (menu != 0);
                    senhaErrada = true;



                }
                else
                {
                    
                    Console.WriteLine($@"Senha invalida!|| Tente novamente!");
                }

            } while (senhaErrada == false);



        }

        static void MostrarMenu()
        {
            Console.WriteLine($@"
=============================
|            MENU           |
|===========================|
|     1-Cadastrar produto   |
|     2-Lista de Pordutos   |
|     0-Sair                |
|============================");
        }
        static void CadastrarProduto()
        {
            do
            {
                if (i2 < tamanhoArrey)
                {
                    Console.WriteLine($"Escreva o nome do produto:");
                    nome[i2] = Console.ReadLine();
                    Console.WriteLine($"Escreva o valor do produto:");
                    valor[i2] = double.Parse(Console.ReadLine());

                    Console.WriteLine("Este produto tem promuçao?(S/N)");
                    promocao = Console.ReadLine().ToLower();
                    if (promocao == "s")
                    {
                        Console.WriteLine("Seu produto esta em promocao!");
                        temPromocao[i2] = true;
                    }
                    else
                    {
                        Console.WriteLine("Seu produto não esta em promocao!");
                        temPromocao[i2] = false;
                    }

                    i2++;

                    Console.WriteLine("Deseja cadastrar outro produto?(s/n)");
                    novoCadastro = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Sua lista de cadastro esta creia!");
                    Aumentarlista();
                    
                    
                    novoCadastro = "n";

                }





            } while (novoCadastro == "s");

        }
        static void ListarProdutos()
        {
            Console.WriteLine($@"
                LISTA DE CADASTRO!
 ________________________________________________");

            for (var i = 0; i < i2; i++)
            {
               
                Console.WriteLine($@"-{i + 1}° nome: { nome[i]} |Preço: R${valor[i]} |Tem promoção: {(temPromocao[i]? "Sim" : "Nao")}  ");
            }
        }

        static void Aumentarlista(){


            Console.WriteLine($"Qual a quantidade de produtos que você deseja aumentar? ");
            tamanhoCopia = int.Parse(Console.ReadLine());
            Array.Resize(ref nome, nome.Length + tamanhoCopia);
            Array.Resize(ref valor, valor.Length + tamanhoCopia);
            Array.Resize(ref temPromocao, temPromocao.Length + tamanhoCopia);
            tamanhoArrey = tamanhoArrey + tamanhoCopia;
            

        }


    }
}


           

            
                
               
            

            












