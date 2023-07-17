

namespace Software2KnowledgeCheck1
{
    internal class CityConstructor<T1> where T1 : Building
    {
        private City _city;

        public CityConstructor(City city)
        {
            if (city == null)
            {
                _city = new City();
            }
            else _city = city;
        }

        public void CreateBuilding(T1 building)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<T1>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                _city.Buildings.Add(building);
            }
        }

        public bool ConstructBuilding<T2>(List<string> materials, bool permit, bool zoning) where T2 : T1
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
