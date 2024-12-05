using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas44 : Megoldas
    {
        public Megoldas44(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<Allampolgar> GridValasz()
        {
            var ismeretlenVegzettseguek = lakosok.Where(l => l.IskolaiVegzettseg == null).ToList();
            int maxIteracio = ismeretlenVegzettseguek.Count >= 3 ? 3 : ismeretlenVegzettseguek.Count;

            Random rnd = new();
            List<Allampolgar> randomIsmeretlenVegzettseguek = new();
            while (randomIsmeretlenVegzettseguek.Count != maxIteracio)
            {
                var randomIsmeretlenVegzettsegu = ismeretlenVegzettseguek[rnd.Next(ismeretlenVegzettseguek.Count())];
                if (!randomIsmeretlenVegzettseguek.Contains(randomIsmeretlenVegzettsegu))
                    randomIsmeretlenVegzettseguek.Add(randomIsmeretlenVegzettsegu);
            }
            return randomIsmeretlenVegzettseguek;
        }
    }
}