using System;
using System.Collections.Generic;

#nullable disable

namespace Videolibrary_CRUD.DataAccess
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int? ReleaseDate { get; set; }
        public string Rating { get; set; }
    }
}
