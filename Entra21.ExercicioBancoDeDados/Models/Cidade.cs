﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioBancoDeDados.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public decimal Pib { get; set; }

        public UnidadeFederativa UnidadeFederativa { get; set; }
    }
}
