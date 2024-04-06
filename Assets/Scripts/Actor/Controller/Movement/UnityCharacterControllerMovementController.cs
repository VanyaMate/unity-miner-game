using System;
using UnityEngine;

namespace Actor.Controller.Movement
{
    public class UnityCharacterControllerMovementController : MonoBehaviourMovementController
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpPower;

        private Vector3 _moveDirection = Vector3.zero;

        public override void Move(Vector2 direction, MovementType movementType)
        {
            float speed = this._speed *
                          movementType switch
                          {
                              MovementType.Fast => 1.5f,
                              MovementType.Normal => 1f,
                              MovementType.Slow => 0.4f,
                              _ => 1f
                          };
            this._SetMoveDirection(direction * speed);
        }

        public override void Move(Vector2 direction)
        {
            this._SetMoveDirection(direction * this._speed);
        }

        public override void Jump()
        {
            if (this._characterController.isGrounded)
            {
                this._moveDirection.y = this._jumpPower;
            }
        }

        private void Update()
        {
            this._ApplyGravitation();
            this._ApplyMoveDirection();
        }

        private void _SetMoveDirection(Vector2 direction)
        {
            Vector3 targetDirection = transform.TransformDirection(new Vector3(direction.x, 0, direction.y));
            this._moveDirection.x = targetDirection.x;
            this._moveDirection.z = targetDirection.z;
        }

        private void _ApplyGravitation()
        {
            if (this._characterController.isGrounded && this._moveDirection.y < 0.0f)
            {
                this._moveDirection.y = -1f;
            }
            else
            {
                this._moveDirection.y -= 9.81f * Time.deltaTime;
            }
        }

        private void _ApplyMoveDirection()
        {
            this._characterController.Move(this._moveDirection * Time.deltaTime);
        }
    }
}