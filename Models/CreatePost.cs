using System;
using Microsoft.AspNetCore.Http;

namespace giorgetti.alessio._5h.SecondaWeb.Models
{
    public class CreatePost
    {
        public IFormFile MyCsv{get;set;}

        public string Descrizione { get; set; }

    }
}