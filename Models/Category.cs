using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PortfolioId { get; set; }
        [ForeignKey("PortfolioId")] 
        public Portfolio Portfolio { get; set; }
       
    }
} 
