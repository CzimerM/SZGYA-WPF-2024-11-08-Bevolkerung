using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas43 : Megoldas
    {
        private double atlagNetto;

        public Megoldas43(List<Allampolgar> lakosok) : base(lakosok)
        {
            atlagNetto = lakosok.Average(l => l.NettoJovedelem);
        }

        public override string MondatValasz()
        {
            return $"Átlag nettó jövedelem: {atlagNetto}";
        }

        public override List<string> ListaValasz()
        {
            var minimumNettoAtlagFelett = lakosok.GroupBy(l => l.Tartomany).Where(g => g.Min(l => l.NettoJovedelem) > atlagNetto).ToList();
            int maxIteracio = minimumNettoAtlagFelett.Count() >= 2 ? 2 : minimumNettoAtlagFelett.Count();

            Random rnd = new();
            List<IGrouping<string, Allampolgar>> tartomanyok = new();
            while (tartomanyok.Count != maxIteracio) 
            {
                var randomTartomany = minimumNettoAtlagFelett[rnd.Next(minimumNettoAtlagFelett.Count())];
                if (!tartomanyok.Contains(randomTartomany))
                    tartomanyok.Add(randomTartomany);
            }
            return tartomanyok.Select(x => $"{x.Key} {x.Min(l => l.NettoJovedelem)}").ToList();
        }
    }
}