using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class MonoBehaviourAudioRandomSoundPlay : MonoBehaviour
    {
        [SerializeField] private List<AudioClip> _clips = new List<AudioClip>();
        private AudioSource _audioSource;

        private void Awake()
        {
            this._audioSource = this.GetComponent<AudioSource>();
            this._audioSource.clip = this._clips[Random.Range(0, this._clips.Count - 1)];
        }
    }
}