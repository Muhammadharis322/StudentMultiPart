using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace StudentMultiPart.Models
{
    public class StudentModel
    {
        public string Name { get; set; }
        public IFormFile Image { get; set; }
    }
}
