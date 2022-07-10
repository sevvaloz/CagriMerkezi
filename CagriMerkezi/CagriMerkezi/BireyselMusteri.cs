using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkezi
{
    internal class BireyselMusteri: Musteri
    {
        public BireyselMusteri()
        {
            Random randomID = new Random();
            base.ID = randomID.Next(500, 1000); //Ticari müşterilerin id'si 1 ile 500 arasında olacak.
            base.MusteriTuru = "bireysel";
        }
    }
}
