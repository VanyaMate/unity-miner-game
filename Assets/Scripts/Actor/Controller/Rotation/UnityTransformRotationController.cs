using UnityEngine;

namespace Actor.Controller.Rotation
{
    public class UnityTransformRotationController : MonoBehaviourRotationController
    {
        [SerializeField] private Transform _body;
        [SerializeField] private Transform _head;

        private float _currentHeadAngle = 0f;

        public override void Rotate(Vector3 position)
        {
            // Расчитать угол поворота на position
            throw new System.NotImplementedException();
        }

        public override void Rotate(Vector2 direction)
        {
            float bodyRotation = direction.x;
            float headRotation = -direction.y;

            this._currentHeadAngle += headRotation;

            if (this._currentHeadAngle > 90f)
            {
                headRotation = 0;
                this._currentHeadAngle = 90f;
            }
            else if (this._currentHeadAngle < -90f)
            {
                headRotation = 0;
                this._currentHeadAngle = -90f;
            }

            this._body.Rotate(Vector3.up, bodyRotation, Space.World);
            this._head.Rotate(Vector3.right, headRotation, Space.Self);
        }
    }
}