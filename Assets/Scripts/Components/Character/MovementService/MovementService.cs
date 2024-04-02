using UnityEngine;

namespace Components.Character.MovementService
{
    public abstract class MovementService : MonoBehaviour, IMovementService
    {
        public abstract float Move(Vector3 direction, float speed);
        public abstract void Rotate(Quaternion angle);
        public abstract bool Jump(float forcePower);
    }
}