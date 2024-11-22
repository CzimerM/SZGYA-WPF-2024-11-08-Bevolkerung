using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas18 : Megoldas
    {
        public Megoldas18(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"Állampolgárok átlagos életkora: {Math.Round(lakosok.Average(l => l.Eletkor), 2)}";
        }
    }
}