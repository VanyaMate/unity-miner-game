using System;
using UnityEngine;

namespace Actor.Controller.Movement
{
    public enum MovementType
    {
        Slow,
        Normal,
        Fast,
    }

    public interface IMovementController
    {
        /**
         * Метод для движения
         */
        void Move(Vector2 direction, MovementType movementType);

        /**
         * Метод для движения
         */
        void Move(Vector2 direction);

        /**
         * Метод для прыжка
         */
        void Jump();
    }
}