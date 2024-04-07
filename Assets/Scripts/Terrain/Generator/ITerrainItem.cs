using UnityEngine;

namespace Terrain.Generator
{
    public interface ITerrainItem
    {
        void SpawnTo(Vector3 position, Vector3 rotation, Vector3 size);
    }
}