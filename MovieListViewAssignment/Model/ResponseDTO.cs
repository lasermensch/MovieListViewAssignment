﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieListViewAssignment.Model
{
    public class ResponseDTO
    {
        [JsonPropertyName("results")]
        public List<Movie> Movies { get; set; }
    }
}
