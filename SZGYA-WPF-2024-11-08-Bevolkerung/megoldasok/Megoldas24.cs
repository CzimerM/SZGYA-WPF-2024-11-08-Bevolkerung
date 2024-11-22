using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas24 : Megoldas
    {
        public Megoldas24(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var dohanyzok = Math.Round(lakosok.Where(l => l.Dohanyzik).Average(l => l.NettoJovedelem),2);
            var nemdohanyzok = Math.Round(lakosok.Where(l => !l.Dohanyzik).Average(l => l.NettoJovedelem),2);

            return $"A {(dohanyzok > nemdohanyzok ? "" : "nem")} dohányzók átlag jövedelme a nagyobb (dohányzók jövedelme: {dohanyzok} EUR, nem szavazók: {nemdohanyzok} EUR).";
        }
    }
}