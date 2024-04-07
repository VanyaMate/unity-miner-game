using Items.Weapons.Bullet.SO;
using UnityEngine;

namespace Items.Weapons.Bullet
{
    public class UnityWeaponBulletSpawner : MonoBehaviour, IWeaponBulletSpawner
    {
        [SerializeField] private GameObject effect;

        public void Spawn(Vector3 direction, SO_Bullet bullet)
        {
            GameObject spawnedBullet = Instantiate(bullet.bullet, transform.position, Quaternion.Euler(direction));
            Instantiate(this.effect, transform.position, transform.rotation);
            Destroy(spawnedBullet, 3f);
        }
    }
}