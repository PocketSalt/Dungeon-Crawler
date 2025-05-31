using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterEquipment : MonoBehaviour
{
    private EntityAttributes stats;

    public WeaponData weapon;
    public HeadGearData head;
    public BodyGearData body;
    public LegGearData legs;

    void Awake()
    {
        stats = GetComponent<EntityAttributes>();     
    }

    private void Start()
    {
        // all Gear must apply stats
        weapon.ApplyStatModifier(stats);
        head.ApplyStatModifier(stats);
        body.ApplyStatModifier(stats);
        legs.ApplyStatModifier(stats);
    }
}
