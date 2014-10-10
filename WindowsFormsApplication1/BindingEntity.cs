using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BindingEntity
    {
        public string source { get; set; }
        public string vhost { get; set; }
        public string destination { get; set; }
        public string destination_type { get; set; }
        public string routing_key { get; set; }
        public string properties_key { get; set; }
        
    }
}
