namespace gnv_back.Models
{
    public class Station
    {
        public long? Id { get; set; }
        public string Name { get; set;}
        public string Street { get; set;}
        public string Number { get; set;}
        public string Neighborhood { get; set;}
        public string City { get; set;}
        public string State { get; set;}
        public string Lat { get; set;}
        public string Lng { get; set;}
    }
}
