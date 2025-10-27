using Vecxy.Diagnostics;
using Vecxy.Engine;
using Zenject;

namespace FlappyBird.Game;

public class Game : IGame
{
    [Inject] private IGameSettings _settings;
        
    public Game()
    {
        Console.WriteLine("Game.Ctor");
    }
    
    public void InstallBindings(DiContainer container)
    {
        Console.WriteLine("Game.InstallBindings");
    }

    public void Initialize()
    {
        Logger.Info("Game.Initialize");
        
        Logger.Info(_settings.Verison);

        _settings.Verison = "test_new_version";
       
        Logger.Info(_settings.Verison);
    }

    public void Update(float deltaTime)
    {
    }
}