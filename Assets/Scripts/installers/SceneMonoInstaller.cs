using Zenject;
using game.model;

public class SceneMonoInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<UserModel>().AsSingle();
    }
}
