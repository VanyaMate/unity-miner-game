using UnityEngine;

namespace Actor.Controller
{
    public abstract class ActorController : IActorController
    {
        // Add move controller
        public void Move(Vector2 direction, ActorMoveType actorMoveType)
        {
            throw new System.NotImplementedException();
        }

        public void Move(Vector2 direction)
        {
            throw new System.NotImplementedException();
        }

        public void Jump()
        {
            throw new System.NotImplementedException();
        }

        // Add rotate controller
        public void Rotate(Vector3 position)
        {
            throw new System.NotImplementedException();
        }

        public void Rotate(Vector2 direction)
        {
            throw new System.NotImplementedException();
        }
    }
}