using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas29 : Megoldas
    {
        public Megoldas29(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.GroupBy(l => l.Tartomany).Select(g => $"{g.Key} id:{g.MaxBy(l => l.SorFogyasztasEvente).Id} {g.Max(l => l.SorFogyasztasEvente)}l").ToList();
        }
    }
}