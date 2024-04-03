using UnityEngine;

namespace Components.Actor.ViewDirections
{
    public abstract class ViewDirectionController : MonoBehaviour, IViewDirectionController
    {
        public abstract void LookAt(Vector3 position);
    }
}