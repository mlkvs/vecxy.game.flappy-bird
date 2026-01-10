using Test;
using Vecxy;
using Vecxy.Diagnostics;
using Vecxy.Engine;

namespace FlappyBird.Game;

public class Boot : Vecxy.Engine.Game
{
    public Boot(GameInfo info) : base(info)
    {
        Logger.Info("Game.Ctor");

        var t = new Class1();
        t.Test();
    }

    public override void Initialize()
    {
        
    }

    public override void Update()
    {
        
    }
}