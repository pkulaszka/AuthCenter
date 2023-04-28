using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthCenter_Bitwarden_Client.Models
{
    public class ItemBase
    {
        public string @object { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string organizationId { get; set; }
        public object folderId { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();
    }
}
