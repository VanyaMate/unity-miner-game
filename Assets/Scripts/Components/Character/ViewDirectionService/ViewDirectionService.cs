using UnityEngine;

namespace Components.Character.ViewDirectionService
{
    public abstract class ViewDirectionService : MonoBehaviour, IViewDirectionService
    {
        public abstract void LookAt(Vector3 position);
    }
}