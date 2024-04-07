using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Terrain.Generator
{
    public class UnityTerrainGenerator : MonoBehaviour, ITerrainGenerator
    {
        [SerializeField] private UnityEngine.Terrain _terrain;
        [SerializeField] private List<TerrainItem> _terrainItems = new List<TerrainItem>();
        [SerializeField] private bool _generate = false;

        public void Generate(UnityEngine.Terrain terrain, List<TerrainItem> items)
        {
            this._RemoveAllFromTerrain();
            this._GenerateItems();
        }

        private void Awake()
        {
            if (this._generate)
            {
                this.Generate(this._terrain, this._terrainItems);
            }
        }

        private void _GenerateItems()
        {
            Vector3 terrainSize = this._terrain.terrainData.size;
            float terrainQuads = Mathf.Ceil(terrainSize.x / 100 * terrainSize.y / 100);
            this._terrainItems.ForEach(
                (terrainItem) =>
                {
                    float generateItemAmount = terrainQuads * terrainItem.amountPerQuad;
                    for (int i = 0; i < generateItemAmount; i++)
                    {
                        // get random vector3
                        Vector3 randomPosition = new Vector3(
                            Random.Range(0, terrainSize.x),
                            0,
                            Random.Range(0, terrainSize.y)
                        );

                        // get random vector3 rotation
                        Vector3 randomRotation = new Vector3(
                            0,
                            Random.Range(0, 360),
                            0
                        );
                        // get random vector3 size
                        Vector3 randomSize = new Vector3(
                                                 Random.Range(8, 12),
                                                 Random.Range(8, 12),
                                                 Random.Range(8, 12)
                                             ) /
                                             20;

                        GameObject generatedElement =
                            Instantiate(terrainItem.item, this._terrain.transform);

                        generatedElement.transform.localPosition = new Vector3(
                            randomPosition.x,
                            this._terrain.SampleHeight(randomPosition),
                            randomPosition.z
                        );
                        generatedElement.transform.localRotation = Quaternion.Euler(randomRotation);
                        generatedElement.GetComponent<Transform>().localScale = randomSize;
                    }
                }
            );
        }

        private void _RemoveAllFromTerrain()
        {
            for (int i = 0; i < this._terrain.transform.childCount; i++)
            {
                Destroy(this._terrain.transform.GetChild(i).gameObject);
            }
        }
    }
}