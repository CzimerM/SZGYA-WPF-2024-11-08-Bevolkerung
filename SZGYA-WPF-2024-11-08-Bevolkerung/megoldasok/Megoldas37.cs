using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas37 : Megoldas
    {
        private List<Allampolgar> atlagFelettiek;
        private double atlagJovedelem;

        public Megoldas37(List<Allampolgar> lakosok) : base(lakosok)
        {
            atlagJovedelem = lakosok.Average(l => l.NettoJovedelem);
            atlagFelettiek = lakosok.Where(l => l.NettoJovedelem > atlagJovedelem).ToList();
        }

        public override List<string> ListaValasz()
        {
            return atlagFelettiek.Select(l => l.ToString(false)).ToList();
        }

        public override string MondatValasz()
        {
            return $"Átlag jövedelem: {Math.Round(atlagJovedelem, 2)} EUR, db lakos: {atlagFelettiek.Count}";
        }
    }
}