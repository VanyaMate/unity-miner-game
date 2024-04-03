using System.Collections.Generic;
using UnityEngine;

namespace Components.Actor.ViewDirections
{
    public class GameObjectViewDirectionController : ViewDirectionController
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