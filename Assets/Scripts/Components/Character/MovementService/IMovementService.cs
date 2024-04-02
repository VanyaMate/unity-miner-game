using UnityEngine;

namespace Components.Character.MovementService
{
    public interface IMovementService
    {
        float Move(Vector3 direction, float speed);
        void Rotate(Quaternion angle);
        bool Jump(float forcePower);
    }
}