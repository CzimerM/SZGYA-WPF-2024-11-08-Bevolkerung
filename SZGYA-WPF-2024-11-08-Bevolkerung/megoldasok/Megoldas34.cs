using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas34 : Megoldas
    {
        public Megoldas34(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"55kg krumplifogyasztás feletti férfiak átlag súlya: {Math.Round(lakosok.Where(l => l.KrumpliFogyasztasEvente > 55).Average(l => l.Suly), 2)} kg";
        }
    }
}