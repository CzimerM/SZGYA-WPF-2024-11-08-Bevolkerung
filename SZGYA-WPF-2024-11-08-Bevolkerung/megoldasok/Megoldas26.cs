using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas26 : Megoldas
    {
        public Megoldas26(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.GroupBy(l => l.Tartomany).Select(g => $"{g.Key} - {Math.Round(g.Average(l => l.Eletkor), 2)}").ToList();
        }
    }
}