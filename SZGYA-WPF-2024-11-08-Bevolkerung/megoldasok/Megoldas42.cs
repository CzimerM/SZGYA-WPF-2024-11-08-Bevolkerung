using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas42 : Megoldas
    {
        private double? atlagSorFogyasztas;

        public Megoldas42(List<Allampolgar> lakosok) : base(lakosok)
        {
            atlagSorFogyasztas = lakosok.Average(l => l.SorFogyasztasEvente);
        }

        public override string MondatValasz()
        {
            return $"Átlag sörfogyasztás: {atlagSorFogyasztas}";
        }
        public override List<string> ListaValasz()
        {
            var atlagFelettiSorfogyasztok = lakosok.Where(l => l.SorFogyasztasEvente > atlagSorFogyasztas).ToList();
            int maxIteracio = atlagFelettiSorfogyasztok.Count >= 5 ? 5 : atlagFelettiSorfogyasztok.Count;
            var randomSorfogyasztok = new List<Allampolgar>();
            Random rnd = new();
            while (randomSorfogyasztok.Count != maxIteracio)
            {
                var randomSorfogyaszto = atlagFelettiSorfogyasztok[rnd.Next(0, atlagFelettiSorfogyasztok.Count)];
                if (!randomSorfogyasztok.Contains(randomSorfogyaszto)) randomSorfogyasztok.Add(randomSorfogyaszto);
            }
            return randomSorfogyasztok.Select(l => l.ToString(true)).ToList();
        }
    }
}