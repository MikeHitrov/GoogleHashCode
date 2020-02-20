using System.Collections.Generic;

namespace GoogleHashCode {
    public class System {
        public List<Library> libs;
        public int B;
        public int L;
        public int D;

        public System (int B, int L, int D) {
            this.libs = new List<Library> ();
            this.B = B;
            this.L = L;
            this.D = D;
        }

        public void addLib (Library lib) {
            this.libs.Add (lib);
        }

        public void Simulate () {
            for (int i = 0; i < this.D; i++) {
                for (int l = 0; l < libs.Count; i++) {
                    //TODO
                }

                this.nextDay ();
            }
        }

        public void nextDay () {
            libs.ForEach (l => l.nd ());
        }
    }
}