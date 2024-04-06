using System;
using Actor.Controller;
using Items.Weapons;
using UnityEngine;

namespace Player.Input
{
    public class TempPlayerInput : MonoBehaviour
    {
        [SerializeField] private HumanActorController _humanActorController;
        [SerializeField] private MonoBehaviourWeaponItemController _behaviourWeapon;

        private float _fireRate = 5;
        private float _nextFire = 0;

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            float horizontalDirection = UnityEngine.Input.GetAxisRaw("Horizontal");
            float verticalDirection = UnityEngine.Input.GetAxisRaw("Vertical");
            float mouseX = UnityEngine.Input.GetAxis("Mouse X");
            float mouseY = UnityEngine.Input.GetAxis("Mouse Y");
            bool jump = UnityEngine.Input.GetKeyDown(KeyCode.Space);
            bool shift = UnityEngine.Input.GetKey(KeyCode.LeftShift);
            bool fire = UnityEngine.Input.GetMouseButton(0);

            this._humanActorController.Move(
                new Vector2(horizontalDirection, verticalDirection).normalized,
                shift ? ActorMoveType.Fast : ActorMoveType.Normal
            );

            this._humanActorController.Rotate(new Vector2(mouseX, mouseY));
            if (jump)
            {
                this._humanActorController.Jump();
            }

            if (fire)
            {
                if (this._nextFire >= 0)
                {
                    this._behaviourWeapon.Shoot();
                    this._nextFire = -1000 / this._fireRate;
                }
            }

            this._nextFire += Time.deltaTime * 1000;
        }
    }
}