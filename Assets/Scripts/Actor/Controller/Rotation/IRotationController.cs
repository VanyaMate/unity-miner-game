using UnityEngine;

namespace Actor.Controller.Rotation
{
    public interface IRotationController
    {
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