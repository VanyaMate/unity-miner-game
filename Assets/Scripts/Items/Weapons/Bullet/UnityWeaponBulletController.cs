using System;
using Items.Weapons.Bullet.SO;
using UnityEngine;

namespace Items.Weapons.Bullet
{
    public class UnityWeaponBulletController : MonoBehaviour, IWeaponBulletController
    {
        [SerializeField] private SO_Bullet _bullet;

        public void Hit()
        {
            Instantiate(this._bullet.hitEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        private void Update()
        {
            // Ну а что поделать...
            RaycastHit hit;
            float distance = this._bullet.speed * Time.deltaTime;
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {
                transform.position = hit.point;
                this.Hit();
            }

            transform.Translate(Vector3.forward * distance);
        }
    }
}