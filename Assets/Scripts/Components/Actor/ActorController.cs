using UnityEngine;

namespace Components.Actor
{
    public abstract class ActorController : MonoBehaviour, IActorController
    {
        public abstract void Move(Vector3 direction, float speed);
        public abstract void Jump(float power);
        public abstract void FlyMode(bool state);
        public abstract void Fly(Vector3 direction, float speed);
        public abstract void Attack(Vector3 direction);
        public abstract void TakeDamage();
        public abstract void Interact();
        public abstract void Die();
    }
}