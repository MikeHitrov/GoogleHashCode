using System;
using System.Linq;

namespace GoogleHashCode {
    class StartUp {
        static void Main (string[] args) {
            int[] bld = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
            Book[] scores = Console.ReadLine ().Split (' ').Select ((i, j) => new Book (j, int.Parse (i))).ToArray ();

            System s = new System (bld[0], bld[1], bld[2]);

            for (int i = 0; i < s.L; i++) {
                int[] bi = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

                Library lib = new Library (i, bi[1], bi[2]);
                int[] lbi = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();

                foreach (int ind in lbi) {
                    lib.addBook (scores[ind]);
                }
            }

            s.Simulate ();
        }
    }
}