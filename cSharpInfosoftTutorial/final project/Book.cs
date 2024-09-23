﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.final_project
{
    class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }
        public Book (string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
            IsBorrowed = false;
        }
    }
}
