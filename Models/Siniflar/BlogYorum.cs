using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraverTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        //IEnumerable, generic olamayan bir koleksiyon üzerinde iterasyon(liste içerisinde dönmemizi) yapmamızı sağlar.

        public IEnumerable<Blog> Deger1 {  get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }

    }
}