using UnityEngine;

namespace Items.Weapons.Mounts
{
    public abstract class MonoBehaviourWeaponUsableMountController : MonoBehaviour, IWeaponUsableMountController
    {
        public abstract void Set(WeaponUsableMountState state);
        public abstract void ToggleNext();
        public abstract void TogglePrev();
    }
}