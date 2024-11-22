using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas16 : Megoldas
    {
        public Megoldas16(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"{Math.Round((double)lakosok.Count(l => l.AktivSzavazo) / lakosok.Count * 100d, 2)} százaléka aktív szavazó";
        }
    }
}