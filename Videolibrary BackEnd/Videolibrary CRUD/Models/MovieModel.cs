using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videolibrary_CRUD.Models
{
    public class MovieModel
    {
        public string title { get; set; }
        public string director { get; set; }
        public string genre { get; set; }
        public int releaseYear { get; set; }
        public string rating { get; set; }
    }
}
