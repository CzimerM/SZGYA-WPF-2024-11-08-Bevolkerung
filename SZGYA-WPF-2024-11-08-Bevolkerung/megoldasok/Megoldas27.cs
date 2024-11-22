using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas27 : Megoldas
    {
        public Megoldas27(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"{lakosok.Count(l => l.Eletkor > 50)} db 50 feletti állampolgár van.";
        }
        public override List<string> ListaValasz()
        {
            return lakosok.Where(l => l.Eletkor > 50).Select(l => l.ToString(true)).ToList();
        }
    }
}