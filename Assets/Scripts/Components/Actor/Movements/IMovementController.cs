using UnityEngine;

namespace Components.Actor.Movements
{
    public interface IMovementController
    {
        float Move(Vector3 direction, float speed);
        void Rotate(Quaternion angle);
        bool Jump(float forcePower);
    }
}