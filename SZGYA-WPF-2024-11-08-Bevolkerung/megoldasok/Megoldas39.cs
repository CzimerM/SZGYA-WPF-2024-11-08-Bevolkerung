using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas39 : Megoldas
    {
        public Megoldas39(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.GroupBy(l => l.Tartomany).Select(g => new { t = g.Key, n = g.Max(g => g.NettoJovedelem)}).OrderBy(l => l.n).Select(l => $"{l.t} {l.n}").ToList();
        }
    }
}