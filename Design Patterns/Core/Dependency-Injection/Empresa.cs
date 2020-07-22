using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Dependency_Injection
{
    class Empresa
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public IEndereco Endereco;

        public Empresa(IEndereco endereco)
        {
            Endereco = endereco;
        }
    }
}
