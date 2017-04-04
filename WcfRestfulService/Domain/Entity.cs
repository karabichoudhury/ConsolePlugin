using System.Runtime.Serialization;

namespace WcfRestfulService.Domain
{
    [DataContract]
    public class Entity
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Exp { get; set; }
    }

    [DataContract]
    public class Status
    {
        [DataMember]
        public string code { get; set; }

        [DataMember]
        public string description { get; set; }
    }
}