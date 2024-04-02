using UnityEngine;

namespace Components.Character.AnimationService
{
    public abstract class AnimationService : MonoBehaviour, IAnimationService
    {
        public abstract void Rotate(AnimationRotateSide side);
        public abstract void Jump(float power);
        public abstract void Move(Vector3 direction, float speed);
        public abstract void Drop(float speed);
        public abstract void Fly(Vector3 direction, float speed);
        public abstract void FlyMode(bool state);
        public abstract void Idle(AnimationHandIdleType handIdleType, AnimationHealthIdleType healthIdleType);
        public abstract void DamageTake();
        public abstract void Attack(AnimationAttackType animationAttackType);
        public abstract void Die();
        public abstract void Spawn();
    }
}