using Design_Patterns.Core;
using Design_Patterns.Core.Builder;
using Design_Patterns.Core.Dependency_Injection;
using Design_Patterns.Core.Factory;
using Design_Patterns.Core.Singleton;
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
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("4 - Dependency Injection");

            var result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    creator = new CreatorFactory();
                    break;
                case "2":
                    creator = new CreatorBuilder();
                    break;
                case "3":
                    creator = new CreatorSingleton();
                    break;
                case "4":
                    creator = new CreatorDependency();
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
