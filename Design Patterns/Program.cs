using Design_Patterns.Core;
using Design_Patterns.Core.Builder;
using Design_Patterns.Core.Factory;
using System;

namespace Design_Patterns
{
    class Program
    {
        static Creator creator;

        static void initialize()
        {
            Console.WriteLine("Estudo sobre Padroes de Projeto, selecione o programa para executar: ");
            Console.WriteLine("1 - Factory");
            Console.WriteLine("2 - Builder");

            var result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    creator = new CreatorFactory();
                    break;
                case "2":
                    creator = new CreatorBuilder();
                    break;
                default:
                    throw new Exception("Padrao nao implementado.");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                initialize();
                creator.execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
