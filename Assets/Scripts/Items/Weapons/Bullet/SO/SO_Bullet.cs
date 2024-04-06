using UnityEngine;

namespace Items.Weapons.Bullet.SO
{
    [CreateAssetMenu(fileName = "so_bullet_", menuName = "Items/Weapons/Bullet", order = 51)]
    public class SO_Bullet : ScriptableObject
    {
        [Header("Meta")] [SerializeField] public string title;
        [SerializeField] public WeaponTypes type;

        [Header("Props")] [SerializeField] public float speed;
        [SerializeField] public float damage;

        [Header("Prefabs")] [SerializeField] public GameObject bullet;
        [SerializeField] public GameObject hitEffect;
        [SerializeField] public GameObject spawnEffect;
    }
}