using Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Core.Dependency_Injection
{
    class Endereco : IEndereco
    {
        public string _cep;
        public string Cep { get => _cep; set => _cep = value; }
    }
}
