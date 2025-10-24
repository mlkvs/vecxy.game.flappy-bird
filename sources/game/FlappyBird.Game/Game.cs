using Vecxy.Engine;
using Zenject;

namespace FlappyBird.Game;

public class Game : IGame
{
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
        Console.WriteLine("Game.Initialize");
    }

    public void Update(float deltaTime)
    {
        Console.WriteLine("Game.Update");
    }
}