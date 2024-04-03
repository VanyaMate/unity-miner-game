using UnityEngine;

namespace Components.Actor
{
    public interface IActorController
    {
        void Move(Vector3 direction, float speed);
        void Jump(float power);
        void FlyMode(bool state);
        void Fly(Vector3 direction, float speed);
        void Attack(Vector3 direction);
        void TakeDamage();
        void Interact();
        void Die();
    }
}