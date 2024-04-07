using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Terrain.Generator
{
    [Serializable]
    public struct TerrainItem
    {
        public GameObject item;
        [Range(0, 30)] public float amountPerQuad;
    }

    public interface ITerrainGenerator
    {
        void Generate(
            UnityEngine.Terrain terrain,
            List<TerrainItem> items
        );
    }
}