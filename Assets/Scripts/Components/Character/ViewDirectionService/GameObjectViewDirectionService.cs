using System.Collections.Generic;
using UnityEngine;

namespace Components.Character.ViewDirectionService
{
    public class GameObjectViewDirectionService : ViewDirectionService
    {
        [SerializeField] private List<GameObject> _rotateElements;

        public override void LookAt(Vector3 position)
        {
            this._rotateElements.ForEach(
                (rotateElement) => { rotateElement.transform.LookAt(position); }
            );
        }
    }
}