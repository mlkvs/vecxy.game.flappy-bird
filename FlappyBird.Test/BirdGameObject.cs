using Vecxy.Diagnostics;
using Vecxy.Engine;

namespace FlappyBird.Test;

public class BirdGameObject : GameObject
{
    public override void Update(float deltaTime)
    {
        Logger.Info("BirdGameObject");
    }
}