using Components.Actor;
using UnityEngine;

namespace Components.Player.InGame
{
    public class PlayerInGameController : MonoBehaviour
    {
        [SerializeField] private HumanActorController _actorController;

        private void Update()
        {
            this._MoveUpdate();
            this._JumpUpdate();
        }

        private void _MoveUpdate()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            bool speedUp = Input.GetKey(KeyCode.LeftShift);
            float speed = speedUp ? 1.5f : 1;

            if (Mathf.Abs(horizontal) == 1 || Mathf.Abs(vertical) == 1)
            {
                this._actorController.Move(new Vector3(horizontal, 0, vertical).normalized, speed);
            }
            else
            {
                this._actorController.Move(new Vector3(horizontal, 0, vertical), speed);
            }
        }

        private void _JumpUpdate()
        {
            bool jump = Input.GetKeyDown(KeyCode.Space);
            if (jump)
            {
                this._actorController.Jump(10f);
            }
        }
    }
}