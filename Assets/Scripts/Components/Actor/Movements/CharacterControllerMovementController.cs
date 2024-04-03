using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Components.Actor.Movements
{
    public class CharacterControllerMovementController : MovementController
    {
        [SerializeField] private float _characterSpeed = 3f;
        [SerializeField] private CharacterController _characterController;

        [SerializeField] private Transform _body;
        private Vector3 _velocity = Vector3.zero;

        public override float Move(Vector3 direction, float speed)
        {
            float characterSpeed = speed * this._characterSpeed;
            float verticalSpeed = this._GetVerticalSpeed();

            Vector3 directionWithSpeed = direction * characterSpeed;
            this._velocity = new Vector3(
                directionWithSpeed.x,
                verticalSpeed,
                directionWithSpeed.z
            );
            return this._characterController.Move(this._velocity * Time.deltaTime) switch
            {
                CollisionFlags.None => 1f,
                CollisionFlags.Sides => .5f,
                CollisionFlags.Above => 0f,
                _ => 1f
            };
        }

        public override void Rotate(Quaternion angle)
        {
            this._body.transform.rotation = angle;
        }

        public override bool Jump(float forcePower)
        {
            if (this._characterController.isGrounded)
            {
                Vector3 jumpDirection = new Vector3(0, forcePower, 0);
                this._velocity += jumpDirection;
                this._characterController.Move(this._velocity * Time.deltaTime);
                return true;
            }
            else
            {
                return false;
            }
        }

        private float _GetVerticalSpeed()
        {
            if (this._characterController.isGrounded)
            {
                return -1f;
            }
            else
            {
                float gravity = Physics.gravity.y * 2 * Time.deltaTime;
                float currentVerticalSpeed = this._velocity.y;
                return currentVerticalSpeed + gravity;
            }
        }
    }
}