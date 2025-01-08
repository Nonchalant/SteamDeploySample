using UseCase.Title;
using Zenject;

namespace Controller.Title
{
    public interface IPresenter
    {
        void OnClickExit();
    }

    public class Presenter : IPresenter
    {
        [Inject] private ITitleUseCase _useCase;

        public Presenter(ITitleUseCase useCase)
        {
            _useCase = useCase;
        }

        public void OnClickExit()
        {
            _useCase.Exit();
        }
    }
}