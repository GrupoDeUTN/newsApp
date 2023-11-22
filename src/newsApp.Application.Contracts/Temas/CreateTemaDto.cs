﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace newsApp.Temas
{
    public class CreateTemaDto
    {
        [Required]
        public string Name { get; set; }
        public int? Id { get; set; }
        public int? ParentId { get; set; }

    }
}
