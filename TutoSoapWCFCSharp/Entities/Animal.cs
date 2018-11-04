using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TutoSoapWCFCSharp.Entities
{
    [DataContract]
    public class Animal
    {
        [DataMember]
        public int AnimalId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual Race race { get; set; }

        public Animal()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}