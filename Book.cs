using System;

namespace GoogleHashCode {
    public class Book : IComparable {
        public int id;
        public int score;

        public Book (int id, int score) {
            this.id = id;
            this.score = score;
        }

        public int CompareTo (object book) {
            if (book == null)
                return 1;

            Book ob = book as Book;

            return this.score.CompareTo (ob.score);
        }
    }
}