using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ExchangeEntity
    {
        public MessageStatsEntity message_stats { get; set; }
        public string name { get; set; }
        public string vhost { get; set; }
        public string type { get; set; }
        public bool durable { get; set; }
        [JsonProperty("internal")]
        public bool internalFlag { get; set; }
        public bool auto_delete { get; set; }

    }


    public class MessageStatsEntity
    {
        public int publish_in { get; set; }
        public PublishindetailsEntity publish_in_details { get; set; }
        public int publish_out { get; set; }
        public PublishoutdetailsEntity publish_out_details { get; set; }
    }

    public class PublishindetailsEntity
    {
        public double rate { get; set; }
    }


    public class PublishoutdetailsEntity
    {
        public double rate { get; set; }
    }
}
