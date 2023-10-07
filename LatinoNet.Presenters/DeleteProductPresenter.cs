using LatinoNet.UseCasesPorts;

namespace LatinoNet.Presenters
{
    public class DeleteProductPresenter : IDeleteProductOutputPort, IPresenter<bool>
    {
        public bool Content { get; private set; }

        public Task Handle(bool productDeleted)
        {
            Content = productDeleted;

            return Task.CompletedTask;
        }
    }
}
