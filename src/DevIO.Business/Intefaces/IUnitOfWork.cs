namespace DevIO.Business.Intefaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
