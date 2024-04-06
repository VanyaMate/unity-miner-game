using Items.Weapons.Bullet.SO;
using UnityEngine;

namespace Items.Weapons.Bullet
{
    public class UnityWeaponBulletSpawner : MonoBehaviour, IWeaponBulletSpawner
    {
        public void Spawn(Vector3 direction, SO_Bullet bullet)
        {
            GameObject spawnedBullet = Instantiate(bullet.bullet, transform.position, Quaternion.Euler(direction));
            Destroy(spawnedBullet, 3f);
        }
    }
}