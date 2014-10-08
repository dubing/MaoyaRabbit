using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class QueueEntity
    {
        public int memory { get; set; }
        public int messages { get; set; }
        public int messages_ready { get; set; }
        public int messages_unacknowledged { get; set; }
        public string idle_since { get; set; }
        public string consumers { get; set; }
        public string state { get; set; }
        public string name { get; set; }
        public string vhost { get; set; }
        public bool durable { get; set; }
        public bool auto_delete { get; set; }
        public string node { get; set; }
    }
}
