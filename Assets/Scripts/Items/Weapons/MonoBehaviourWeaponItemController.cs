using UnityEngine;

namespace Items.Weapons
{
    public abstract class MonoBehaviourWeaponItemController : MonoBehaviour, IWeaponItemController
    {
        public abstract void Shoot();
        public abstract void Reload();
    }
}