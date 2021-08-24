using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            //Resposta 1 = "a";
            //Resposta 2 = "e";
            //Resposta 3 = "d";
            //Resposta 4 = "b";
            //Resposta 5 = "c";
            do
            {
                //Menu
                menu();
                int op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        string resp1, resp2, resp3, resp4, resp5;
                        int p = 0;
                        pergunta1();
                        Console.SetCursorPosition(13, 9);
                        resp1 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        pergunta2();
                        Console.SetCursorPosition(13, 9);
                        resp2 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        pergunta3();
                        Console.SetCursorPosition(13, 9);
                        resp3 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        pergunta4();
                        Console.SetCursorPosition(13, 9);
                        resp4 = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        pergunta5();
                        Console.SetCursorPosition(13, 9);
                        resp5 = Console.ReadLine();
                        Console.Clear();
                        resp1 = resp1.ToUpper();
                        resp2 = resp2.ToUpper();
                        resp3 = resp3.ToUpper();
                        resp4 = resp4.ToUpper();
                        resp5 = resp5.ToUpper();
                        Console.WriteLine("\n      Respostas\n------------------------");
                        Console.WriteLine(" 1. Resposta: A | Você digitou: " + resp1 + " | \n 2. Resposta: E | Você digitou: " + resp2 + " | \n 3. Resposta: D | Você digitou: " + resp3 + " | \n 4. Resposta: B | Você digitou: " + resp4 + " | \n 5. Resposta: C | Você digitou: " + resp5 + " | ");
                        if (resp1 == "A")
                        {
                            Console.SetCursorPosition(36, 3);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correta");
                            p++;
                        }
                        else
                        {
                            Console.SetCursorPosition(36, 3);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Incorreta");
                        }
                        if (resp2 == "E")
                        {
                            Console.SetCursorPosition(36, 4);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correta");
                            p++;
                        }
                        else
                        {
                            Console.SetCursorPosition(36, 4);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Incorreta");
                        }
                        if (resp3 == "D")
                        {
                            Console.SetCursorPosition(36, 5);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correta");
                            p++;
                        }
                        else
                        {
                            Console.SetCursorPosition(36, 5);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Incorreta");
                        }
                        if (resp4 == "B")
                        {
                            Console.SetCursorPosition(36, 6);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correta");
                            p++;
                        }
                        else
                        {
                            Console.SetCursorPosition(36, 6);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Incorreta");
                        }
                        if (resp5 == "C")
                        {
                            Console.SetCursorPosition(36, 7);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Correta");
                            p++;
                        }
                        else
                        {
                            Console.SetCursorPosition(36, 7);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Incorreta");
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nVocê acertou " + p + " de 5 perguntas");
                        break;

                    case 2:
                        string re;
                        int a = 0;
                        do
                        {
                            pergunta1();
                            if (a == 1)
                                Console.Write(+a + " Erro");
                            if (a >= 2)
                                Console.Write(+a + " Erros");
                            Console.SetCursorPosition(13, 9);
                            re = Convert.ToString(Console.ReadLine());
                            a++;
                            Console.Clear();
                        } while (a != 5 && re != "a");
                        if (re == "a")
                        {
                            a = a - 1;
                            do
                            {
                                pergunta2();
                                if (a == 1)
                                    Console.Write(+a + " Erro");
                                if (a >= 2)
                                    Console.Write(+a + " Erros");
                                Console.SetCursorPosition(13, 9);
                                re = Convert.ToString(Console.ReadLine());
                                a++;
                                Console.Clear();
                            } while (a != 5 && re != "e");
                            if (re == "e")
                            {
                                a = a - 1;
                                do
                                {
                                    pergunta3();
                                    if (a == 1)
                                        Console.Write(+a + " Erro");
                                    if (a >= 2)
                                        Console.Write(+a + " Erros");
                                    Console.SetCursorPosition(13, 9);
                                    re = Convert.ToString(Console.ReadLine());
                                    a++;
                                    Console.Clear();
                                } while (a != 5 && re != "d");
                                if (re == "d")
                                {
                                    a = a - 1;
                                    do
                                    {
                                        pergunta4();
                                        if (a == 1)
                                            Console.Write(+a + " Erro");
                                        if (a >= 2)
                                            Console.Write(+a + " Erros");
                                        Console.SetCursorPosition(13, 9);
                                        re = Convert.ToString(Console.ReadLine());
                                        a++;
                                        Console.Clear();
                                    } while (a != 5 && re != "b");
                                    a = a - 1;
                                    if (re == "b")
                                    {
                                        a = a - 1;
                                        do
                                        {
                                            pergunta5();
                                            if (a == 1)
                                                Console.Write(+a + " Erro");
                                            if (a >= 2)
                                                Console.Write(+a + " Erros");
                                            Console.SetCursorPosition(13, 9);
                                            re = Convert.ToString(Console.ReadLine());
                                            a++;
                                            Console.Clear();
                                        } while (a != 5 && re != "c");
                                        a = a - 1;
                                        if (re == "c")
                                            ganhou();
                                    }
                                }
                            }
                        }
                        if (a == 5)
                            perdeu();
                        break;
                    case 3:
                        string res;
                        int e = 0;
                        do
                        {
                            pergunta1();
                            Console.SetCursorPosition(13, 9);
                            res = Convert.ToString(Console.ReadLine());
                            e++;
                            Console.Clear();
                        } while (e != 1 && res != "a");
                        if (res == "a")
                        {
                            e = e - 1;
                            do
                            {
                                pergunta2();
                                Console.SetCursorPosition(13, 9);
                                res = Convert.ToString(Console.ReadLine());
                                e++;
                                Console.Clear();
                            } while (e != 1 && res != "e");
                            if (res == "e")
                            {
                                e = e - 1;
                                do
                                {
                                    pergunta3();
                                    Console.SetCursorPosition(13, 9);
                                    res = Convert.ToString(Console.ReadLine());
                                    e++;
                                    Console.Clear();
                                } while (e != 1 && res != "d");
                                if (res == "d")
                                {
                                    e = e - 1;
                                    do
                                    {
                                        pergunta4();
                                        Console.SetCursorPosition(13, 9);
                                        res = Convert.ToString(Console.ReadLine());
                                        e++;
                                        Console.Clear();
                                    } while (e != 1 && res != "b");
                                    e = e - 1;
                                    if (res == "b")
                                    {
                                        e = e - 1;
                                        do
                                        {
                                            pergunta5();
                                            Console.SetCursorPosition(13, 9);
                                            res = Convert.ToString(Console.ReadLine());
                                            e++;
                                            Console.Clear();
                                        } while (e != 1 && res != "c");
                                        e = e - 1;
                                        if (res == "c")
                                            ganhou();
                                    }
                                }
                            }
                        }
                        if (e == 1)
                            perdeu();
                        break;
                    default:
                        Console.WriteLine("\n-------------------------------\nNão quer continuar no programa?");
                        break;
                }
                Console.WriteLine("\nPara continuar digite [S]\nPara sair digite [N]");
                w = Convert.ToString(Console.ReadLine());
                Console.Clear();

            }
            while (w == "s");
        }
        private static void menu()
        {
            Console.WriteLine("\n      Quiz de Lógica\n----------------------------\n\n      Escolha o Modo\n[1] Médio (Sem Tentativas)\n[2] Intermediário (5 Tentativas) \n[3] Difícil (1 Tentativa)\n[4] Sair\n\n----------------------------");
        }
        private static void pergunta1()
        {
            Console.WriteLine("\n--------------------------------------------------------\n 1. Usamos as funções numéricas 'Math.Tan', 'Math.Sqrt' e 'Math.Pow' respectivamente para:");
            Console.WriteLine("[a] Obter a tangente, raiz quadrada e potenciação.\n[b] Obter a raiz quadrada, tangente e potenciação.\n[c] Obter a tangente, potenciação e raiz quadrada.\n[d] Obter a potenciação, tangente e raiz quadrada.\n[e] Obter a tangente, seno e potenciação.\n\nA resposta é\n\n--------------------------------------------------------");
        }
        private static void pergunta2()
        {
            Console.WriteLine("\n--------------------------------------------------------\n 2. Sobre a estrututa if - else, responda com a sintaxe mais correta.");
            Console.WriteLine("[a] if {a == b}  {} \n[b] if (a == b);\n[c] if [a == b] { }\n[d] if (a == b) [ ]\n[e] if (a == b) { }\n\nA resposta é\n\n--------------------------------------------------------");
        }
        private static void pergunta3()
        {
            Console.WriteLine("\n--------------------------------------------------------\n 3. Qual a função do operador aritmético 'MOD' ou '%' ?");
            Console.WriteLine("[a] Armazenar o resultado um soma.\n[b] Armazenar a raiz quadrada de um número.\n[c] Armazenar o logarítmo na base 10.\n[d] Armazenar o resto de uma divisão.\n[e] Armazenar o valor arrendodado de um número.\n\nA resposta é\n\n--------------------------------------------------------");
        }
        private static void pergunta4()
        {
            Console.WriteLine("\n--------------------------------------------------------\n 4. Sobre a diferença entre as estruturas de repetição 'While' e 'For'.");
            Console.WriteLine("[a] Mesmo sendo iguais, no For não precisa inserir a condição, sendo mais facil ter um loop infinito.\n[b] O While não tem um contador previamente determinado como o For, possibilitando mais formas de saída.\n[c] No While a condição vem no início do programa, diferente do For que é no final.\n[d] Os dois são iguais e apresentam a mesma sintaxe.\n[e] No For não há o uso de variaveis, facilitando seu uso.\n\nA resposta é\n\n--------------------------------------------------------");
        }
        private static void pergunta5()
        {
            Console.WriteLine("\n--------------------------------------------------------\n 5. Qual é o conceito de função?");
            Console.WriteLine("[a] Funções são grandes algoritmos com vários operadores.\n[b] Variaveis com comandos previamente determinados.\n[c] São blocos de código separados do programa principal e que podem ser chamados quando necessário.\n[d] Uma estrutura que repete assim que é chamada no programa.\n[e] Blocos composto apenas váriaveis de texto.\n\nA resposta é\n\n--------------------------------------------------------");
        }
        private static void perdeu()
        {
            Console.WriteLine("\n      Tente novamente\n        Você perdeu\n----------------------------");
        }
        private static void ganhou()
        {
            Console.WriteLine("\n      Parabéns\n     Você ganhou\n---------------------------- ");
        }
    }
}
