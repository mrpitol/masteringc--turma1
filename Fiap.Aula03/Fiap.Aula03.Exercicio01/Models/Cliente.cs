﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula03.Exercicio01.Models
{
    class Cliente
    {
        //Propriedades prop -> tab tab
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        //Construtor
        //ctor -> tab tab 
        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
