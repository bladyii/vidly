using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.DataHandler.Encoder;

namespace Vidly.DTOs
{
    public class GenresDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}