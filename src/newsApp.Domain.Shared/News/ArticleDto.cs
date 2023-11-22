using System;
using System.Collections.Generic;
using System.Text;

namespace newsApp.News
{
    public class ArticleDto
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string URL { get; set; }
        public string URLImagen { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
