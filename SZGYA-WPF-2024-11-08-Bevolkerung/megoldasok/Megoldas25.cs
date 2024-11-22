using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas25 : Megoldas
    {
        public Megoldas25(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"Átlagos krumplifogyaszás: {Math.Round((decimal)lakosok.Average(l => l.KrumpliFogyasztasEvente), 2)} kg";
        }

        public override List<Allampolgar> GridValasz()
        {
            return lakosok.Where(l => l.KrumpliFogyasztasEvente > lakosok.Average(l => l.KrumpliFogyasztasEvente)).OrderBy(l => l.KrumpliFogyasztasEvente).Take(15).ToList();
        }
    }
}