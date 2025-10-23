using System;
using Vecxy.Engine;
using Zenject;

namespace FlappyBird.Game;

public class Game : IGame
{
    public Game()
    {
        Console.WriteLine("test2");
    }
    
    public void InstallBindings(DiContainer container)
    {
        System.Diagnostics.Debugger.Break();
        Console.WriteLine("testasas");
    }

    public void Initialize()
    {
        Console.WriteLine("test");
    }

    public void Update(float deltaTime)
    {
        
    }
}