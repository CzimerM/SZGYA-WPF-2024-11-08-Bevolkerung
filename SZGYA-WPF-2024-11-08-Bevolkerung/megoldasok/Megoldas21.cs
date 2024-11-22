using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas21 : Megoldas
    {
        public Megoldas21(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var szavazok = lakosok.Where(l => l.AktivSzavazo).Count(l => l.SorFogyasztasEvente > 0);
            var nemszavazok = lakosok.Where(l => !l.AktivSzavazo).Count(l => l.SorFogyasztasEvente > 0);
            return $"A {(szavazok > nemszavazok ? "" : "nem")} szavazók fogyasztanak több sört (szavazók: {szavazok}, nem szavazók: {nemszavazok}).";
        }
    }
}