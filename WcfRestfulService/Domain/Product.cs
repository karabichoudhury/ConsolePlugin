using System.Runtime.Serialization;

namespace WcfRestfulService.Domain
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public int Price { get; set; }
    }
}