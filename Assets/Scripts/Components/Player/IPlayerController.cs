using UnityEngine;

namespace Components.Player
{
    public interface IPlayerController
    {
        void Move(Vector3 direction);
    }
}