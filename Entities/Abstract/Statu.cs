using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Statu
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}
