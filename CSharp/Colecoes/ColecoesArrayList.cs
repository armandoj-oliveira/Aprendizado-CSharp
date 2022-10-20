﻿using System;
using System.Collections;


namespace CSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach (var item in arraylist) {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}
