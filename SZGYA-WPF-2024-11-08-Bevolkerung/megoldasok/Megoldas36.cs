using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas36 : Megoldas
    {
        public Megoldas36(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.Select(l => new { n = l.Nemzetiseg, t = l.Tartomany }).Distinct().Select(a => $"{a.n} - {a.t}").ToList();
        }
    }
}