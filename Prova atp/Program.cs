using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estudosstring ();
            Exerciciostring ();
            //EscapeString ();
            //Substring ();
        }

        private static void Estudosstring ()
        {

            Console.WriteLine ("Escreva sua msg");
            string input = Console.ReadLine ();

            //Console.WriteLine (input[0]);
            //Console.WriteLine (input.Length);


            //  qual n comeca;ate qual n vai; subindo ++ ou descendo --
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write (input[i]);
            }    

                Console.Write ("-");

            for (int i = input.Length -1 ; i >= 0 ; i-- )
            {
                Console.Write (input[i]);
            }  

        }

        private static void Exerciciostring ()
        {
            // Peça ao usuário para digitar uma palavra ou frase e depois exiba essa string ao contrário.
           /* Console.WriteLine("Escreva uma palavra: ");
            string input = Console.ReadLine ();

            for ( int i = input.Length -1; i >= 0; i--){
                Console.Write (input[i]);
            }
            */ 


            /*Peça ao usuário para inserir uma frase e, em seguida, conte e exiba quantas palavras estão
            presentes na frase fornecida. Considere que as palavras são separadas por espaços*/

            Console.WriteLine ("insira uma frase: ");
            string input = ConsoleReadLine ();

            int numeropalavras = 0; 

            
            
        }

        private static void EscapeString ()
        {
            String teste = "esse eh meu \"exemplo\" de string com aspas!";
            System.Console.WriteLine(teste);
        }

        private static void Substring ()
        {
            string test = "esse eh um teste de substring, vamos ver como funciona!";
            string resultado = test.Substring(5);
            Console.WriteLine(resultado);

            resultado = test.Substring (5, 10);
            Console.WriteLine(resultado);
        }

    }
} 


  /*
                
                CONCATENACAO:
                Console.WriteLine("Seu nome eh " + nome + " e sua idade eh " + idade); 

                OPERADORES:
                 para strings  ==  !=  
                 para int  ==  !=  >=  <=  
                  || = ou    &&  = e        

                IF / ELSE / ELSE IF
                if - necessario especificar (if what?) Exemplo: 
                if (A == 1) {}

                else - nao eh necessario especificar 

                else if - possibilidade de retorno do if + especificacao de outro if
                pode ser encadeado para fazer uma sequencia de else's e if's  

                SWITCH 
                para diminuir a quantidade de linhas pode se usar switch em alguns casos no lugar do if/else
                o switch "faz uma troca" do numero no case pelo seu equivalente no if/else, e deve ser terminado em break; ou n sera compilado exemplo:
                case 1: Console.WriteLine("xxxxxxxxxx");  
                break;
                case 2: Console.WriteLine("xxxxxxxxxx");  
                break;
                case 3: Console.WriteLine("xxxxxxxxxx");  
                break;

                FOR LOOPS
                sintaxe: for (declarar int,double etc...; delcara a variavel e usar um dos operadores e a segunda variavel; Variavel++ para repeticao)
                         for (int i = 0; i >= userinput; i++){}

                WHILE LOOPS
                sintaxe: 
                while (condicao){}

                DO WHILE
                exemplo: 

                Console.WriteLine("Insira um numero: ");
               int numA = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Insira o segundo numero ");
               int numB = Convert.ToInt32(Console.ReadLine());

               int respostareal = numA * numB;
               int respostainput = 0; 
               Console.WriteLine("qual eh a mutiplicacao do numero " + numA + "x" + numB + "?");
               

               
               do {
                Console.WriteLine("insira sua resposta: ");
                respostainput = Convert.ToInt32(Console.ReadLine());

                if (respostainput != respostareal) {
                    Console.WriteLine("voce errou tente novamente!");
                }

               } while (respostainput != respostareal);
                 
                Console.WriteLine("parabens voce acertou!");




                //CONDICAO ? TRUE OR FALSE 
                para substituir if else pode usar, variavvel = condicao seguido de ? "texto desejado verdadeiro" : "texto desejado falso"
                string resultado = idade >= 0 ? "valido" : "invalido";
                Console.WriteLine(resultado);






                //FORMATACAO de valor
                
                double valor = 1000 / 12.34;

                System.Console.WriteLine(valor);
                System.Console.WriteLine(string.Format("{0: 0}",valor));
                System.Console.WriteLine(string.Format("{0: 0.#}",valor));
                System.Console.WriteLine(string.Format("{0: 0.00}",valor));

                FORMATACAO DINHEIRO 
                double dinheiro = 10.0 / 3.0;

                System.Console.WriteLine(string.Format("R${0: 0.00}", dinheiro));
               




                */