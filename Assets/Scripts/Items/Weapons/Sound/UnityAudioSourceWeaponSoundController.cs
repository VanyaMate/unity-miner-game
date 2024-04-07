using UnityEngine;

namespace Items.Weapons.Sound
{
    public class UnityAudioSourceWeaponSoundController : MonoBehaviour, IWeaponSoundController
    {
        [SerializeField] private AudioSource _audioSource;
        
        public void Shoot()
        {
            this._audioSource.Play();
        }

        public void Reload()
        {
            throw new System.NotImplementedException();
        }
    }
}