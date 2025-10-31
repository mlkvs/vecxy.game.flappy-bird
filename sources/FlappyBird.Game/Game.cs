using System.Runtime.Serialization;
using Vecxy.Diagnostics;
using Vecxy.Engine;
using Zenject;
//using Newtonsoft.Json;

namespace FlappyBird.Game;

[DataContract]
public class TClass
{
    [DataMember(Name = "test")] public string Test { get; set; }
}

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
        
        var json = @"{""test"": ""hello from json""}";

        var tClass = JsonConvert.DeserializeObject<TClass>(json);
        
        Logger.Info(tClass?.Test ?? "Not deserialize json object");

    }

    public void Update(float deltaTime)
    {
    }
}