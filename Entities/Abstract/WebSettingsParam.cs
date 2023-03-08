using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class WebSettingsParam
    {
        public Guid Id { get; set; }
        public string Arrangement { get; set; }
        public string Title { get; set; }
        public string Page { get; set; }
        public string Value { get; set; }
        public string InputValue { get; set; }
    }
}
