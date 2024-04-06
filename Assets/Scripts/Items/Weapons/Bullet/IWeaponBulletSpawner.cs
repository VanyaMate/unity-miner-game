using Items.Weapons.Bullet.SO;
using UnityEngine;

namespace Items.Weapons.Bullet
{
    public interface IWeaponBulletSpawner
    {
        void Spawn(Vector3 direction, SO_Bullet bullet);
    }
}