﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class EntityBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int? StatuId { get; set; }
        public string CreateDate { get; set; }
        public string ModifiedName { get; set; }
        public string isDeleted { get; set; }

        public virtual Statu Status { get; set; }
    }
}
