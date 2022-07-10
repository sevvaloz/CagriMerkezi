using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkezi
{
    internal class Cagri
    {
        public DateTime gorusmeBaslangic { get; set; }
        public DateTime gorusmeBitis { get; set; }

        public List<TicariCagriTemsilcisi> List_TicariCagriTemsilcisi { get; set; }
        public List<BireyselCagriTemsilcisi> List_BireyselCagriTemsilcisi { get; set; }
        public List<TicariMusteri> List_TicariMusteri { get; set; }
        public List<BireyselMusteri> List_BireyselMusteri { get; set; }

        public Cagri()
        {
            List_TicariCagriTemsilcisi = new List<TicariCagriTemsilcisi>();
            List_BireyselCagriTemsilcisi = new List<BireyselCagriTemsilcisi>();
            List_TicariMusteri = new List<TicariMusteri>();
            List_BireyselMusteri = new List<BireyselMusteri>();
        }
    }
}
