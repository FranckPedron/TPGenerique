using System;
using System.Collections.Generic;
using System.Text;

namespace TPGenerique
{
    class Chainage<T>
    {
        public Chainage<T> Precedent { get; set; }
        public Chainage<T> Suivant { get; set; }
        public T Valeur { get; set; }
    }
}
