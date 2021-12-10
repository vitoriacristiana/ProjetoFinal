using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.Clear();

            menu:
            mold();//moldura
            
            Console.SetCursorPosition(20,2);
            Console.WriteLine("Escolha a Operação");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            menu();                                           //menu


            Console.ResetColor();                             //|
            Console.SetCursorPosition(10,11);                 //|
            Console.Write("Opção desejada : ");               //|-- Entrada Opção
            Console.SetCursorPosition(27,11);                 //|
            Console.ForegroundColor = ConsoleColor.DarkMagenta;  //|
            op = int.Parse(Console.ReadLine());               //|
            Console.ResetColor();

             switch(op)
            {
                case 1:
                Console.Clear();
                mold();
                soma();
                sn:
                Console.SetCursorPosition(5,9);
                Console.Write("Deseja voltar ao menu? S/N : ");
                string sn = Console.ReadLine().ToUpper();
                if(sn == "S"){goto menu;}
                else if(sn == "N"){Console.SetCursorPosition(0,12);}
                else
                {Console.ForegroundColor = ConsoleColor.DarkYellow; 
                Console.SetCursorPosition(27,10);
                Console.WriteLine("Opção Inválida"); 
                Console.ResetColor(); goto sn;}
                break;

                case 2:
                Console.Clear();
                mold();
                sub();
                sn2:
                Console.SetCursorPosition(5,9);
                Console.Write("Deseja voltar ao menu? S/N : ");
                string sn2 = Console.ReadLine().ToUpper();
                if(sn2 == "S"){goto menu;}
                else if(sn2 == "N"){Console.SetCursorPosition(0,12);}
                else
                {Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.SetCursorPosition(27,10);
                Console.WriteLine("Opção Inválida"); 
                Console.ResetColor(); goto sn2;}
                break;

                 case 3:
                Console.Clear();
                mold();
                mult();
                sn3:
                Console.SetCursorPosition(5,9);
                Console.Write("Deseja voltar ao menu? S/N : ");
                string sn3 = Console.ReadLine().ToUpper();
                if(sn3 == "S"){goto menu;}
                else if(sn3 == "N"){Console.SetCursorPosition(0,12);}
                else
                {Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.SetCursorPosition(27,10);
                Console.WriteLine("Opção Inválida"); 
                Console.ResetColor(); goto sn3;}
                break;

                case 4:
                Console.Clear();
                mold();
                div();
                sn4:
                Console.SetCursorPosition(5,9);
                Console.Write("Deseja voltar ao menu? S/N : ");
                string sn4 = Console.ReadLine().ToUpper();
                if(sn4 == "S"){goto menu;}
                else if(sn4 == "N"){Console.SetCursorPosition(0,12);}
                else
                {Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.SetCursorPosition(27,10);
                Console.WriteLine("Opção Inválida"); 
                Console.ResetColor(); goto sn4;}
                break;

                case 5:
                Console.Clear();
                mold();
                exp();
                sn5:
                Console.SetCursorPosition(5,9);
                Console.Write("Deseja voltar ao menu? S/N : ");
                string sn5 = Console.ReadLine().ToUpper();
                if(sn5 == "S"){goto menu;}
                else if(sn5 == "N"){Console.SetCursorPosition(0,12);}
                else
                {Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.SetCursorPosition(27,10);
                Console.WriteLine("Opção Inválida"); 
                Console.ResetColor(); goto sn5;}
                break;
             
             case 6:
                Console.Clear();
                mold();
                rad();
                sn6:
                Console.SetCursorPosition(5,9);
                Console.Write("Deseja voltar ao menu? S/N : ");
                string sn6 = Console.ReadLine().ToUpper();
                if(sn6 == "S"){goto menu;}
                else if(sn6 == "N"){Console.SetCursorPosition(0,12);}
                else
                {Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.SetCursorPosition(27,10);
                Console.WriteLine("Opção Inválida"); 
                Console.ResetColor(); goto sn6;}
                break;

                case 7:
                Console.Clear();
                mold();
                bhas();
                sn7:
                Console.SetCursorPosition(5,11);
                Console.Write("Deseja voltar ao menu? S/N : ");
                string sn7 = Console.ReadLine().ToUpper();
                if(sn7 == "S"){goto menu;}
                else if(sn7 == "N"){creditos();Console.SetCursorPosition(0,12);}
                else
                {Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.SetCursorPosition(27,10);
                Console.WriteLine("Opção Inválida"); 
                Console.ResetColor(); goto sn7;}
                break;
            }

             }
        static void mold()//linha 1 até 12 - Moldura
        {
            int c = 1;
            while(c<=12)
            {
                if(c ==1)
                {
                    Console.SetCursorPosition(3,c);
                    Console.WriteLine("╔════════════════════════════════════════════════╗");
                }
                if(c == 12)
                {
                    Console.SetCursorPosition(3,c);
                    Console.WriteLine("╚════════════════════════════════════════════════╝");
                }
                else
                {
                    Console.SetCursorPosition(3,c+1);
                    Console.WriteLine("║                                      ║");
                }
                c++;
            }
        }
        static void menu()//linha 3 até 9 - Menu de Opções
        {
            Console.SetCursorPosition(10,3);
            Console.WriteLine("1. Soma");
            Console.SetCursorPosition(10,4);
            Console.WriteLine("2. Subtração");
            Console.SetCursorPosition(10,5);
            Console.WriteLine("3. Multipliacação");
            Console.SetCursorPosition(10,6);
            Console.WriteLine("4. Divisão");
            Console.SetCursorPosition(10,7);
            Console.WriteLine("5. Exponenciação");
            Console.SetCursorPosition(10,8);
            Console.WriteLine("6. Radiação");
            Console.SetCursorPosition(10,9);
            Console.WriteLine("7. Bháskara");
            
        }
        static void soma()
        {
            Console.SetCursorPosition(20,2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Soma '+' ---");
            Console.ResetColor();
            Console.SetCursorPosition(10,3);
            Console.Write("1° Número : ");
            double n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,5);
            Console.Write("2° Número : ");
            double n2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10,7);
            Console.Write($"Resultado : {n1 + n2}");
            Console.ResetColor();
        
        }
        static void sub()
        {
            Console.SetCursorPosition(18,2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Subtração '-' ---");
            Console.ResetColor();
            Console.SetCursorPosition(10,3);
            Console.Write("1° Número : ");
            double n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,5);
            Console.Write("2° Número : ");
            double n2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10,7);
            Console.Write($"Resultado : {n1 - n2}");
            Console.ResetColor();
        }

        static void mult()
        {
            Console.SetCursorPosition(14,2);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--- Multiplicação 'X,*,.' ---");
            Console.ResetColor();
            Console.SetCursorPosition(10,3);
            Console.Write("1° Número : ");
            double n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,5);
            Console.Write("2° Número : ");
            double n2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10,7);
            Console.Write($"Resultado : {n1 * n2}");
            Console.ResetColor();
        }

        static void div()
        {
            Console.SetCursorPosition(18,2);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--- Divisão ':,/' ---");
            Console.ResetColor();
            Console.SetCursorPosition(10,3);
            Console.Write("1° Número : ");
            double n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,5);
            Console.Write("2° Número : ");
            double n2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10,7);
            Console.Write($"Resultado : {n1 / n2}");
            Console.ResetColor();
        }
            static void exp()
        {
            Console.SetCursorPosition(17,2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Exponenciacão ---");
            Console.ResetColor();
            Console.SetCursorPosition(10,3);
            Console.Write("Número : ");
            double n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,5);
            Console.Write("Expoente : ");
            double n2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10,7);
            Console.Write($"Resultado : {Math.Pow(n1,n2)}");
            Console.ResetColor();

             }
        static void rad()
        {
            Console.SetCursorPosition(19,2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Radiação ---");
            Console.ResetColor();
            Console.SetCursorPosition(10,3);
            Console.Write("Indice : ");
            double n1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,5);
            Console.Write("Radicando : ");
            double n2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10,7);
            Console.Write($"Resultado : {Math.Pow((n2),(1/n1))}");
            Console.ResetColor();
        }
        static void bhas()
        {
            Console.SetCursorPosition(19,2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Bháskara ---");
            Console.ResetColor();

            Console.SetCursorPosition(10,3);
            Console.Write("(a) : ");
            double a = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,5);
            Console.Write("(b) : ");
            double b = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(10,7);
            Console.Write("(c) : ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b,2) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            double x2 = (-b - Math.Sqrt(delta)) / 2 * a; 

            if(a == 0){Console.SetCursorPosition(10,9);Console.WriteLine("Não é uma equação de 2º grau");}
            else if(delta < 0){Console.SetCursorPosition(10,9); Console.WriteLine($"Delta = {delta:N2}, não possui raizes reais! ");}
            else{Console.SetCursorPosition(10,9); Console.WriteLine($"x' = {x1:N2}  x'' = {x2:N2} ");}
        }
        static void creditos()
        {
            Console.Clear();
            mold();
            Console.SetCursorPosition(20,2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Créditos ---");
            Console.ResetColor();
            Console.SetCursorPosition(4,3);
            Console.WriteLine("Projeto criado para obtenção de");
            Console.SetCursorPosition(4,4);
            Console.WriteLine("nota na matéria de PC do curso");
            Console.SetCursorPosition(4,5);
            Console.WriteLine("de Informática");
            Console.SetCursorPosition(4,6);
            Console.WriteLine("Administrado pelos professores");
            Console.SetCursorPosition(4,7);
            Console.WriteLine("Diego Neri e Ermogenes Palácio");
            Console.SetCursorPosition(20,8);
            Console.WriteLine("Desenvolvido por Vitória Cristiana");
            Console.SetCursorPosition(20,9);
            Console.WriteLine("GitHub:https://github.com/vitoriacristiana");
            Console.SetCursorPosition(20,10);
            Console.WriteLine("Email:vitoriacristiana290@gmail.com");

        }
    }
}
