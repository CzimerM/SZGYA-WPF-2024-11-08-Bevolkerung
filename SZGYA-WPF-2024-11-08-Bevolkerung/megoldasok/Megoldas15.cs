using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas15 : Megoldas
    {
        public Megoldas15(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            var legszegenyebb = lakosok.OrderBy(l => l.NettoJovedelem).Take(3);
            var leggazdagabb = lakosok.OrderByDescending(l => l.NettoJovedelem).Take(3);
            return leggazdagabb.Concat(legszegenyebb).Select(l => l.ToString(false)).ToList();
        }
    }
}