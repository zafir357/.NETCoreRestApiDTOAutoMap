﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class EquipeEntity
    {
        public int Id { get; set; }
        public string NomEquipe { get; set; }
        public ICollection<JoueurEntity> Joueurs { get; set; }
    }
}
