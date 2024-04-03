using Components.Actor.Animations;
using Components.Actor.Movements;
using Components.Actor.ViewDirections;
using UnityEngine;

namespace Components.Actor
{
    public class HumanActorController : ActorController
    {
        [SerializeField] private CharacterControllerMovementController _movementController = null;
        [SerializeField] private HumanAnimationController _animationController = null;
        [SerializeField] private GameObjectViewDirectionController _viewDirectionController = null;

        public override void Move(Vector3 direction, float speed)
        {
            this._movementController?.Move(direction, speed);
            this._animationController?.Move(direction, speed);
        }

        public override void Jump(float power)
        {
            this._movementController?.Jump(power);
            this._animationController?.Jump(power);
        }

        public override void FlyMode(bool state)
        {
            throw new System.NotImplementedException();
        }

        public override void Fly(Vector3 direction, float speed)
        {
            throw new System.NotImplementedException();
        }

        public override void Attack(Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        public override void TakeDamage()
        {
            throw new System.NotImplementedException();
        }

        public override void Interact()
        {
            throw new System.NotImplementedException();
        }

        public override void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}