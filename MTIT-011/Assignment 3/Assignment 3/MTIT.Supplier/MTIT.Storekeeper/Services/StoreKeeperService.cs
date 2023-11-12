using MTIT.Storekeeper.Data;


namespace MTIT.Storekeeper.Services
{
    public class StorekeeperService : IStorekeeperService
    {
        public List<Models.Storekeeper> GetStorekeepers()
        {
            return StorekeeperMockDataService.Storekeepers;

        }

        public Models.Storekeeper? GetStorekeeper(int id)
        {
            return StorekeeperMockDataService.Storekeepers.FirstOrDefault(x => x.Id == id);
        }

        public Models.Storekeeper? AddStorekeeper(Models.Storekeeper storekeeper)
        {
            StorekeeperMockDataService.Storekeepers.Add(storekeeper);
            return storekeeper;
        }




        public Models.Storekeeper? UpdateStorekeeper(Models.Storekeeper storekeeper)
        {
            Models.Storekeeper selectedStorekeeper = StorekeeperMockDataService.Storekeepers.FirstOrDefault(x => x.Id == storekeeper.Id);
            if (selectedStorekeeper != null)
            {
                selectedStorekeeper.ItemName = storekeeper.ItemName;
                selectedStorekeeper.ItemQuantity = storekeeper.ItemQuantity;
                selectedStorekeeper.ItemPrice = storekeeper.ItemPrice;
                return selectedStorekeeper;
            }
            return selectedStorekeeper;

        }




        public bool? DeleteStorekeeper(int id)
        {
            Models.Storekeeper selectedStorekeeper = StorekeeperMockDataService.Storekeepers.FirstOrDefault(x => x.Id == id);
            if (selectedStorekeeper != null)
            {
                StorekeeperMockDataService.Storekeepers.Remove(selectedStorekeeper);
                return true;

            }
            return false;

        }
    }
}


