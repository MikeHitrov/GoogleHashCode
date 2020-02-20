using System;
using System.Collections.Generic;

namespace GoogleHashCode {
    public class Library {
        public int id;
        private SortedList<int, Book> books;
        public int daysToSignUp;
        public int booksPerDay;

        public bool isSigned = false;
        public bool isSigning = false;

        public int cd = 0;

        public Library (int id, int daysToSignUp, int booksPerDay) {
            this.id = id;
            this.books = new SortedList<int, Book> ();
            this.daysToSignUp = daysToSignUp;
            this.booksPerDay = booksPerDay;
        }

        public void addBook (Book book) {
            this.books.Add (book.score, book);
        }

        public void removeBook (Book book) {
            this.books.RemoveAt (book.id);
        }

        public void nd () {
            this.cd++;

            if (isSigning) {
                this.daysToSignUp--;
            } else if (daysToSignUp == 0) {
                this.isSigning = false;
                this.isSigned = true;
            }
        }

        public int score () {
            int n = this.books.Count - 1;
            int cnt = 0;

            for (; n > n - this.booksPerDay; n--) {
                cnt += this.books[n].score;
            }

            return cnt;
        }
    }
}