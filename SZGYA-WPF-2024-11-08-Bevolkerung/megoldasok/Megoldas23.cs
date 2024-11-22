using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas23 : Megoldas
    {
        public Megoldas23(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"A következő népcsoportba tartoznak a legtöbben: {lakosok.GroupBy(l => l.Nepcsoport).OrderBy(g => g.Count()).MaxBy(g => g.Average(l => l.Eletkor)).Key}";
        }
    }
}