namespace LatinoNet.UseCasesPorts
{
    public interface IDeleteProductOutputPort
    {
        Task Handle(bool productDeleted);
    }
}
