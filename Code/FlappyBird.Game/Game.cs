using Test;
using Vecxy.Diagnostics;
using Vecxy.Engine;

namespace FlappyBird.Game;

public class Game : Application
{
    public Game()
    {
        Logger.Info("Game.Ctor");

        var t = new Class1();
        t.Test();
    }

    public override void OnInitialize()
    {
       
    }

    public override void OnTick()
    {
    }
}