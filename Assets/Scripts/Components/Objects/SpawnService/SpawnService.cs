using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

namespace Components.Objects.SpawnService
{
    [RequireComponent(typeof(Transform))]
    public class ObjectSpawnService : MonoBehaviour, ISpawnService
    {
        [SerializeField] [NotNull] private Transform _spawnTransform;

        public ObjectSpawnService([NotNull] Transform spawnTransform)
        {
            this._spawnTransform = spawnTransform;
        }

        public GameObject Spawn(GameObject spawnObject, Vector3 position, Quaternion rotation)
        {
            GameObject spawnedObject = Instantiate(spawnObject, this._spawnTransform);
            spawnedObject.transform.position = position;
            spawnedObject.transform.rotation = rotation;
            return spawnedObject;
        }
    }
}