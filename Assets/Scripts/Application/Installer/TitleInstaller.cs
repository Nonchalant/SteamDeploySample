using Controller.Title;
using UseCase.Title;
using Zenject;

namespace Application.Installer
{
    public class TitleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<ITitleUseCase>()
                .To<TitleUseCase>()
                .AsSingle();
            
            Container
                .Bind<IPresenter>()
                .To<Presenter>()
                .AsSingle();
        }
    }
}