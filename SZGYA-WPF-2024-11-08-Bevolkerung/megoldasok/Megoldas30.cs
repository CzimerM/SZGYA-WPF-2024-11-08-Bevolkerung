﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas30 : Megoldas
    {
        public Megoldas30(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return new List<string>
            {
                lakosok.Where(l => l.Nem == "férfi").MaxBy(l => l.Eletkor).ToString(true),
                lakosok.Where(l => l.Nem == "nő").MaxBy(l => l.Eletkor).ToString(true),
            };
        }
    }
}