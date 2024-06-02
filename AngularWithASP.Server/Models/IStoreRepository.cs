namespace AngularWithASP.Server.Models {
    public interface IStoreRepository {

        IQueryable<Product> Products { get; }
    }
}
