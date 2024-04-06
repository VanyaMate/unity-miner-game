using UnityEngine;

namespace Actor.Controller
{
    public enum ActorMoveType
    {
        Slow,
        Normal,
        Fast,
    }

    public interface IActorController
    {
        /**
         * Метод для движения
         */
        void Move(Vector2 direction, ActorMoveType actorMoveType);

        /**
         * Метод для движения
         */
        void Move(Vector2 direction);

        /**
         * Метод для прыжка
         */
        void Jump();

        /**
         * Повернуться на определенную точку (тело + голова)
         */
        void Rotate(Vector3 position);

        /**
         * Повернуться на определенный градус относительного текущего положения
         */
        void Rotate(Vector2 direction);
    }
}