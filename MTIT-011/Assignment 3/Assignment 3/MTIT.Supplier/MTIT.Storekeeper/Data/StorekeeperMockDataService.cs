using System.Reflection;

namespace MTIT.Storekeeper.Data
{
    public class StorekeeperMockDataService
    {
        public static List<Models.Storekeeper> Storekeepers = new List<Models.Storekeeper>()
        {
            new Models.Storekeeper { Id = 1, ItemName ="Dialog Adapter",ItemQuantity ="25",ItemPrice =25000},
            new Models.Storekeeper { Id = 2, ItemName ="Dialog Phone",ItemQuantity ="40",ItemPrice =20000},
            new Models.Storekeeper { Id = 3, ItemName ="Dialog Satellite",ItemQuantity ="30",ItemPrice =24000},
            new Models.Storekeeper { Id = 4, ItemName ="Dialog Broadband ",ItemQuantity ="100",ItemPrice =18000},
            new Models.Storekeeper { Id = 5, ItemName ="Dialog Sim",ItemQuantity ="150",ItemPrice =15000}

        };
    }
}
