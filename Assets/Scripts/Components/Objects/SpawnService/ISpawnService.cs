using UnityEngine;

namespace Components.Objects.SpawnService
{
    public interface ISpawnService
    {
        GameObject Spawn(GameObject spawnObject, Vector3 position, Quaternion rotation);
    }
}