using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Dependency_Injection
{
    class Dependency : IPattern
    {
        public void execute()
        {
            var endereco = new Endereco();
            endereco.Cep = "31111-11";

            Empresa empresa = new Empresa(endereco);
            empresa.Nome = "DTI";
            empresa.NomeFantasia = "DTI Digital Crafters";

            Console.WriteLine("Empresa: " + empresa.Nome + ", Endereco: " + empresa.Endereco.Cep);
        }
    }
}
