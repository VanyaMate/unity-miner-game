using UnityEngine;

namespace Components.Actor.ViewDirections
{
    public interface IViewDirectionController
    {
        void LookAt(Vector3 position);
    }
}