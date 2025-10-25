using FlappyBird.Test;
using Vecxy.Diagnostics;
using Vecxy.Engine;
using Zenject;

namespace FlappyBird.Game;

public class Game : IGame
{
    [Inject] private ISceneManager _sceneManager;
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

        var scene = _sceneManager.CreateScene("Game");
        
        scene.Load();
        _sceneManager.ActivateScene(scene);

        var bird = new BirdGameObject();
        
        //scene.RootGameObjects.Add(bird);
    }

    public void Update(float deltaTime)
    {
        //Console.WriteLine("Game.Update");
    }
}