

namespace Software2KnowledgeCheck1
{
    internal class Program
    { 
        public static void Main(string[] args)
    
        {
            CityConstructor<Building> CityConstructor = new CityConstructor<Building> (new City());
            CityConstructor.CreateBuilding(new HighRise());
            CityConstructor.CreateBuilding(new Apartment());
            
        }
    }
}
