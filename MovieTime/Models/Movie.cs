using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class Movie
    { //This is a comment
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
    }
}