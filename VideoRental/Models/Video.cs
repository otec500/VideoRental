﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class Video  //klasa reprezentujaca wideo
    {
        public int Id { get; set; }     //id bedzie unikalne generowane przez baze danych
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
    }

    public enum Genre
    {
        Comedy = 1,
        Horror,
        SciFi,
        Romance,
        Documentary,
        Kids
    }
}