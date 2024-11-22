using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas32 : Megoldas
    {
        public Megoldas32(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.GroupBy(l => l.Tartomany).OrderBy(g => g.Count()).Select(g => g.Key).ToList();
        }
    }
}