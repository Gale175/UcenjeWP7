using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GSALE
{
    public class Smjer : Entitet, IComparable<Smjer>
    {
        public string? Naziv { get; set; }

        public int CompareTo(Smjer? other) 
        {

            if (Naziv == null) 
            {
                return -1;
            }
            return Naziv.CompareTo(other?.Naziv);
        }
    }
}
