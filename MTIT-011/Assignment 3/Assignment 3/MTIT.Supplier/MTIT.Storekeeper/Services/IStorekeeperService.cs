namespace MTIT.Storekeeper.Services
{
    public interface IStorekeeperService
    {
        List<Models.Storekeeper> GetStorekeepers();
        Models.Storekeeper? GetStorekeeper(int id);
        Models.Storekeeper? AddStorekeeper(Models.Storekeeper storekeeper);
        Models.Storekeeper? UpdateStorekeeper(Models.Storekeeper storekeeper);
        bool? DeleteStorekeeper(int id);

    }
}