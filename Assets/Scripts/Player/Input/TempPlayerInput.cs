using Actor.Controller;
using UnityEngine;

namespace Player.Input
{
    public class TempPlayerInput : MonoBehaviour
    {
        [SerializeField] private HumanActorController _humanActorController;

        private void Update()
        {
            float horizontalDirection = UnityEngine.Input.GetAxisRaw("Horizontal");
            float verticalDirection = UnityEngine.Input.GetAxisRaw("Vertical");
            float mouseX = UnityEngine.Input.GetAxis("Mouse X");
            float mouseY = UnityEngine.Input.GetAxis("Mouse Y");
            bool jump = UnityEngine.Input.GetKeyDown(KeyCode.Space);
            bool shift = UnityEngine.Input.GetKey(KeyCode.LeftShift);

            this._humanActorController.Move(
                new Vector2(horizontalDirection, verticalDirection).normalized,
                shift ? ActorMoveType.Fast : ActorMoveType.Normal
            );

            this._humanActorController.Rotate(new Vector2(mouseX, mouseY));
            if (jump)
            {
                this._humanActorController.Jump();
            }
        }
    }
}