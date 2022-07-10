using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkezi
{
    internal class TicariMusteri: Musteri
    {
        public TicariMusteri()
        {
            Random randomID = new Random();
            base.ID = randomID.Next(1, 500); //Ticari müşterilerin id'si 1 ile 500 arasında olacak.
            base.MusteriTuru = "ticari";
        }
    }
}
