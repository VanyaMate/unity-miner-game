using System;
using UnityEngine;

namespace Items.Weapons.Mounts.Laser.SO
{
    [CreateAssetMenu(fileName = "so_weapon_mount_laser_", menuName = "Items/Weapons/Mount/Laser", order = 51)]
    public class SO_Weapon_Mount_Laser : ScriptableObject
    {
        [SerializeField] public string title;
        [SerializeField] public Color color;
        [SerializeField] public float size;
    }
}