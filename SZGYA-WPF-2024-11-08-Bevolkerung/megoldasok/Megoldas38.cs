using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas38 : Megoldas
    {
        public Megoldas38(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return new List<string>
            {
                $"nők: {lakosok.Count(l => l.Nem == "nő")} db",
                $"férfiak: {lakosok.Count(l => l.Nem == "férfi")} db"
            };
        }
    }
}