using System;
using UnityEngine;

namespace Components.Actor.Movements
{
    public abstract class MovementController : MonoBehaviour, IMovementController
    {
        public abstract float Move(Vector3 direction, float speed);
        public abstract void Rotate(Quaternion angle);
        public abstract bool Jump(float forcePower);
    }
}