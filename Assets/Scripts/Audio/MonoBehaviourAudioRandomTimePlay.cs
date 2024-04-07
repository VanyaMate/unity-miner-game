using UnityEngine;

namespace Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class MonoBehaviourAudioRandomTimePlay : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Awake()
        {
            this._audioSource = this.GetComponent<AudioSource>();
            float randomTime = this._audioSource.clip.length / 100 * Random.Range(0, 100);
            this._audioSource.time = randomTime;
            this._audioSource.Play();
        }
    }
}