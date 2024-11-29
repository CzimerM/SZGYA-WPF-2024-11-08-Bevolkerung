using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas41 : Megoldas
    {
        public Megoldas41(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            var torokSzavazok = lakosok.Where(l => l.Nemzetiseg == "török" && l.AktivSzavazo).ToList();
            int maxIteracio = torokSzavazok.Count >= 10 ? 10 : torokSzavazok.Count;
            var randomTorokok = new List<Allampolgar>();
            Random rnd = new();
            while (randomTorokok.Count != maxIteracio)
            {
                var randomTorok = torokSzavazok[rnd.Next(0, torokSzavazok.Count)];
                if (!randomTorokok.Contains(randomTorok)) randomTorokok.Add(randomTorok);
            }
            return randomTorokok;
        }
    }
}