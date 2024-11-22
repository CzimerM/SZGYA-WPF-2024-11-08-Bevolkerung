using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas28 : Megoldas
    {
        public Megoldas28(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override string MondatValasz()
        {
            var noiDohanyzok = lakosok.Where(l => l.Dohanyzik && l.Nem == "nő");
            return $"Dohányzó nők maximális nettó jövedelme: {(noiDohanyzok.Count() > 0 ? noiDohanyzok.Max(l => l.NettoJovedelem) : "nincs ilyen")}";
        }
        public override List<string> ListaValasz()
        {
            return lakosok.Where(l => l.Dohanyzik && l.Nem == "nő").Select(l => l.ToString(false)).ToList();
        }
    }
}