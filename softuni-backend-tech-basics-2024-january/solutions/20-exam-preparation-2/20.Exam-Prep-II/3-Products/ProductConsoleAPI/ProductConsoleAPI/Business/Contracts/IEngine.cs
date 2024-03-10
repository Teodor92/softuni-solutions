namespace ProductConsoleAPI.Business.Contracts
{
    public interface IEngine
    {
        Task Run(IProductsManager productManager);
    }
}
