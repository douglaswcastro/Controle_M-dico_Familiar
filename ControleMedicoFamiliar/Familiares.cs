﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    public class Familiares
    {
        public string Nome;
        public string Parentesco;

        List<Familiares> listFamiliar = new List<Familiares>();

         public void Adicionar(string nome, string parentesco)
        {
            listFamiliar.Add(new Familiares() { Nome = nome, Parentesco = parentesco });
        }

        public List<Familiares> Listar() => listFamiliar;
    }
}
