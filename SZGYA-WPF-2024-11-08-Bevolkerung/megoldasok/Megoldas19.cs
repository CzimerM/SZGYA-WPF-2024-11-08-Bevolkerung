using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas19 : Megoldas
    {
        public Megoldas19(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var maxAtlagJovedelem = lakosok.GroupBy(l => l.Tartomany).Max(g => g.Average(l => l.NettoJovedelem));
            var leggazdagabbTartomany = lakosok.GroupBy(l => l.Tartomany).Where(g => g.Average(l => l.NettoJovedelem) == maxAtlagJovedelem).OrderByDescending(g => g.Count()).First();
            return $"A leggazdagabb tartomány {leggazdagabbTartomany.Key} {leggazdagabbTartomany.Count()} lakossal, {leggazdagabbTartomany.Average(g => g.NettoJovedelem)} EUR átlag nettó jövedelemmel";
        }
    }
}