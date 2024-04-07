using System;
using Items.Weapons.Mounts.Laser.SO;
using UnityEngine;

namespace Items.Weapons.Mounts.Laser
{
    public class UnityWeaponLaserController : MonoBehaviourWeaponUsableMountController
    {
        [SerializeField] private SO_Weapon_Mount_Laser _laser;
        [SerializeField] private GameObject _laserPoint;
        [SerializeField] private LineRenderer _lineRenderer;

        private Transform _worldLaserPoint;
        private WeaponUsableMountState _currentState = WeaponUsableMountState.Active;

        private void Awake()
        {
            this._worldLaserPoint = Instantiate(this._laserPoint, transform.position, Quaternion.identity)
                .GetComponent<Transform>();
            this._worldLaserPoint.gameObject.SetActive(true);
            this._lineRenderer.enabled = true;
        }

        private void LateUpdate()
        {
            if (this._currentState == WeaponUsableMountState.Active)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
                {
                    this._worldLaserPoint.gameObject.SetActive(true);
                    this._worldLaserPoint.position = hit.point;
                    this._lineRenderer.SetPositions(
                        new Vector3[]
                        {
                            transform.position,
                            hit.point
                        }
                    );
                }
                else
                {
                    this._worldLaserPoint.gameObject.SetActive(false);
                    this._lineRenderer.SetPositions(
                        new Vector3[]
                        {
                            transform.position,
                            transform.position + transform.forward * 20
                        }
                    );
                }
            }
        }

        public override void Set(WeaponUsableMountState state)
        {
            throw new NotImplementedException();
        }

        public override void ToggleNext()
        {
            this._currentState = this._currentState switch
            {
                WeaponUsableMountState.Active => WeaponUsableMountState.Disable,
                WeaponUsableMountState.Disable => WeaponUsableMountState.Active,
                _ => WeaponUsableMountState.Active
            };
            this._SetLaserPointState();
        }

        public override void TogglePrev()
        {
            throw new NotImplementedException();
        }

        private void _SetLaserPointState()
        {
            if (this._currentState == WeaponUsableMountState.Active)
            {
                this._worldLaserPoint.gameObject.SetActive(true);
                this._lineRenderer.enabled = true;
            }
            else
            {
                this._worldLaserPoint.gameObject.SetActive(false);
                this._lineRenderer.enabled = false;
            }
        }
    }
}