using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas20 : Megoldas
    {
        public Megoldas20(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            return $"Az állampolgárok átlag súlya: {Math.Round(lakosok.Average(l => l.Suly), 2)} kg, medián súlya: {Median()} kg";
        }

        public double Median()
        {
            var elemek = lakosok.OrderBy(l => l.Suly).ToList();
            if (elemek.Count() % 2 == 0)
                return (elemek[elemek.Count() / 2].Suly + elemek[elemek.Count() / 2 + 1].Suly) / 2;
            else 
                return elemek[(int)Math.Ceiling(elemek.Count()/2d)].Suly;
        }
    }
}