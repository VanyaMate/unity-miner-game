using UnityEngine;

namespace Components.Character.ViewDirectionService
{
    public interface IViewDirectionService
    {
        void LookAt(Vector3 position);
    }
}