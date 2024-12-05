using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas45 : Megoldas
    {
        List<Allampolgar> elsoOtNemBajorEgyetemiVegzettseguNo;
        public Megoldas45(List<Allampolgar> lakosok) : base(lakosok)
        {
            elsoOtNemBajorEgyetemiVegzettseguNo = lakosok.Where(l => l.Nem == "nő" && l.Nepcsoport != "bajor" && l.IskolaiVegzettseg == "Universität").Take(5).ToList();
        }

        public override List<Allampolgar> GridValasz()
        {
            return elsoOtNemBajorEgyetemiVegzettseguNo;
        }

        public override List<string> ListaValasz()
        {
            var maradek = lakosok.Except(elsoOtNemBajorEgyetemiVegzettseguNo);
            var tobbJovedelemNok = maradek.Where(l => l.NettoJovedelem > elsoOtNemBajorEgyetemiVegzettseguNo[0].NettoJovedelem && l.Nem == "nő").ToList();
            int maxIteracio = tobbJovedelemNok.Count() >= 3 ? 3 : tobbJovedelemNok.Count();

            Random rnd = new();
            List<Allampolgar> randomNok = new();
            while (randomNok.Count != maxIteracio)
            {
                var randomNo = tobbJovedelemNok[rnd.Next(tobbJovedelemNok.Count)];
                if (!randomNok.Contains(randomNo))
                    randomNok.Add(randomNo);
            }
            return randomNok.Select(x => x.ToString(true)).ToList();

        }
    }
}
