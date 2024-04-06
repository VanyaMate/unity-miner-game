using Items.Weapons.Bullet;
using Items.Weapons.Bullet.SO;
using UnityEngine;

namespace Items.Weapons
{
    public class UnityAk74WeaponItemController : MonoBehaviourWeaponItemController
    {
        [SerializeField] private SO_Bullet _bullet;
        [SerializeField] private UnityWeaponBulletSpawner _bulletSpawner;

        public override void Shoot()
        {
            this._bulletSpawner.Spawn(transform.rotation.eulerAngles, this._bullet);
        }

        public override void Reload()
        {
            throw new System.NotImplementedException();
        }
    }
}