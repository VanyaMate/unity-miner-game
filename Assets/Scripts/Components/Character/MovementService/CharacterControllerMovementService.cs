using UnityEngine;
using UnityEngine.Serialization;

namespace Components.Character.MovementService
{
    public class CharacterControllerMovementService : MovementService
    {
        [SerializeField] private CharacterController _characterController;

        [SerializeField] private Transform _body;

        public override float Move(Vector3 direction, float speed)
        {
            return this._characterController.Move(direction * speed) switch
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
                this._characterController.Move(this._characterController.velocity + new Vector3(0, 1, 0) * forcePower);
                return true;
            }

            return false;
        }
    }
}