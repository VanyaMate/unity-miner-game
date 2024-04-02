using System;
using UnityEngine;

namespace Components.Character.AnimationService
{
    public enum AnimationRotateSide
    {
        Left,
        Right
    }

    public enum AnimationAttackType
    {
        Hands,
        Knife,
        OneHandGun,
        TwoHandGun,
        MachineGun,
        Launcher
    }

    public enum AnimationHandIdleType
    {
        Hands,
        Knife,
        OneHandGun,
        TwoHandGun,
        MachineGun,
        Launcher
    }

    public enum AnimationHealthIdleType
    {
        Healthy,
        SlightlyWounded,
        SeriouslyWounded
    }

    public interface IAnimationService
    {
        void Rotate(AnimationRotateSide side);
        void Jump(float power);
        void Move(Vector3 direction, float speed);
        void Drop(float speed);
        void Fly(Vector3 direction, float speed);
        void FlyMode(bool state);
        void Idle(AnimationHandIdleType handIdleType, AnimationHealthIdleType healthIdleType);
        void DamageTake();
        void Attack(AnimationAttackType animationAttackType);
        void Die();
        void Spawn();
    }
}