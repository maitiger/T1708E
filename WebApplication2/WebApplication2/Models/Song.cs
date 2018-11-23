using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string songname { get; set; }
        public string songSinger { get; set; }
        public string songAuthor { get; set; }
        public string Thumnail { get; set; }
        public string Link { get; set; }
        public List<SongCategory> SongCategories { get; set; }

    }
}
