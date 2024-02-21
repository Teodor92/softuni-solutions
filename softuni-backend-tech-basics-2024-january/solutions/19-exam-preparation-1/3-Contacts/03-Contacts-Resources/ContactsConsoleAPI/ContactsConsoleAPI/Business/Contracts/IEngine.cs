namespace ContactsConsoleAPI.Business.Contracts
{
    public interface IEngine
    {
        Task Run(IContactManager contactManager);
    }
}
