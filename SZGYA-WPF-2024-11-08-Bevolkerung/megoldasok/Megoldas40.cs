using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas40 : Megoldas
    {
        public Megoldas40(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var arany = lakosok.Where(l => l.Nemzetiseg == "német").Average(l => l.HaviJovedelem) / lakosok.Where(l => l.Nemzetiseg != "német").Average(l => l.HaviJovedelem);
            return $"német/nem német arány: {Math.Round(arany * 100, 2)}%";
        }
    }
}