using System;
using UnityEngine;

namespace Actor.Controller.Movement
{
    public abstract class MonoBehaviourMovementController : MonoBehaviour, IMovementController
    {
        public abstract void Move(Vector2 direction, MovementType movementType);
        public abstract void Move(Vector2 direction);
        public abstract void Jump();
    }
}