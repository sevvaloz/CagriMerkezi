using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkezi
{
    internal class BireyselCagriTemsilcisi: CagriTemsilcisi
    {
        public BireyselCagriTemsilcisi()
        {
            base.Tur = "bireysel";
        }
    }
}
