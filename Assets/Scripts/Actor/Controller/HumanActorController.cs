using Actor.Controller.Movement;
using Actor.Controller.Rotation;
using UnityEngine;

namespace Actor.Controller
{
    public class HumanActorController : MonoBehaviour, IHumanActorController
    {
        [SerializeField] private MonoBehaviourMovementController _movementController;
        [SerializeField] private MonoBehaviourRotationController _rotationController;

        public void Move(Vector2 direction, ActorMoveType actorMoveType)
        {
            this._movementController.Move(
                direction,
                actorMoveType switch
                {
                    ActorMoveType.Fast => MovementType.Fast,
                    ActorMoveType.Normal => MovementType.Normal,
                    ActorMoveType.Slow => MovementType.Slow,
                    _ => MovementType.Normal
                }
            );
        }

        public void Move(Vector2 direction)
        {
            this._movementController.Move(direction);
        }

        public void Jump()
        {
            this._movementController.Jump();
        }

        public void Rotate(Vector3 position)
        {
            throw new System.NotImplementedException();
        }

        public void Rotate(Vector2 direction)
        {
            this._rotationController.Rotate(direction);
        }

        public void ChangePosition(HumanActorPositionType humanActorPositionType)
        {
            throw new System.NotImplementedException();
        }

        public void UseItemInHands()
        {
            throw new System.NotImplementedException();
        }

        public void UseFeatureOfItemInHands()
        {
            throw new System.NotImplementedException();
        }

        public void TakeInTheHands()
        {
            throw new System.NotImplementedException();
        }

        public void ThrowFromHands()
        {
            throw new System.NotImplementedException();
        }

        public void PutInInventory()
        {
            throw new System.NotImplementedException();
        }

        public void TakeFromInventory()
        {
            throw new System.NotImplementedException();
        }

        public void Use()
        {
            throw new System.NotImplementedException();
        }
    }
}