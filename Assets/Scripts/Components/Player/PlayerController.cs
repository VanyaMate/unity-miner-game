using System;
using Components.Character.AnimationService;
using Components.Character.MovementService;
using Components.Character.ViewDirectionService;
using UnityEngine;

namespace Components.Player
{
    public class PlayerController : MonoBehaviour, IPlayerController
    {
        [SerializeField] private AnimationService _animationService;
        [SerializeField] private MovementService _movementService;
        [SerializeField] private ViewDirectionService _viewDirectionService;

        public void Move(Vector3 direction)
        {
            this._animationService?.Move(direction, 1);
            this._movementService?.Move(direction, 1);
        }

        private void Update()
        {
            this.Move(new Vector3(1, 0, 0) * Time.deltaTime);
        }
    }
}