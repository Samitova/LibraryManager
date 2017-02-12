﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    class LibraryContextInitializer : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext db)
        {
            Author a1 = new Author { FirstName = "John", SecondName = "Dow", BirthDate = DateTime.Parse("14.03.1984") };
            Author a2 = new Author { FirstName = "Liza", SecondName = "Willow", BirthDate = DateTime.Parse("15.04.1822") };
            Author a3 = new Author { FirstName = "Erick", SecondName = "Dill", BirthDate = DateTime.Parse("12.01.1953") };
           
            db.Authors.Add(a1);
            db.Authors.Add(a2);
            db.Authors.Add(a3);          

            db.SaveChanges();

            Book b1 = new Book { Title = "Mistary", PublishingDate = 2001, Author=a1 };
            Book b2 = new Book { Title = "Animal timming", PublishingDate = 2002, Author = a1 };
            Book b3 = new Book { Title = "Bald man", PublishingDate = 2005, Author = a1 };
            Book b4 = new Book { Title = "Dull day", PublishingDate = 1860, Author = a2 };
            Book b5 = new Book { Title = "Old man", PublishingDate = 1865, Author = a2 };
            Book b6 = new Book { Title = "Little dog", PublishingDate = 1964, Author = a2 };
            Book b7 = new Book { Title = "Treasure", PublishingDate = 1988, Author = a3 };
            Book b8 = new Book { Title = "Black rose", PublishingDate = 1984, Author = a3 };
            Book b9 = new Book { Title = "Wild life", PublishingDate = 1985, Author = a3 };
            Book b10 = new Book { Title = "Come back", PublishingDate = 1990, Author = a3 };
           

            db.Books.AddRange(new List<Book>() { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10});
            db.SaveChanges();
        }
    }
}