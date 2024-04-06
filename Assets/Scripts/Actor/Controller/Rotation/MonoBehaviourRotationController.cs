using UnityEngine;

namespace Actor.Controller.Rotation
{
    public abstract class MonoBehaviourRotationController : MonoBehaviour, IRotationController
    {
        public abstract void Rotate(Vector3 position);
        public abstract void Rotate(Vector2 direction);
    }
}