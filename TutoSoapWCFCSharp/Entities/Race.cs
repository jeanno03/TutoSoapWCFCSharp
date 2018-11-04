using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TutoSoapWCFCSharp.Entities
{
    [DataContract]
    public class Race
    {
        [DataMember]
        public int RaceId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual ICollection<Animal>Animals { get; set; }

        public Race()
        {
            Animals = new HashSet<Animal>();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}