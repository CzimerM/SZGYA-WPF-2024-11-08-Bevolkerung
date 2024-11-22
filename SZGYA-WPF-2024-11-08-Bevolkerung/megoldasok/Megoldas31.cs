﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung.megoldasok
{
    internal class Megoldas31 : Megoldas
    {
        public Megoldas31(List<Allampolgar> lakosok) : base(lakosok)
        { }
        public override List<string> ListaValasz()
        {
            return lakosok.Select(l => l.Nemzetiseg).Distinct().OrderByDescending(l => l).ToList();
        }
    }
}