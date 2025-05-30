using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scythe", menuName = "Items/Weapons/Melee/Scythe")]
public class ScytheData : MeleeWeaponData, IStatModifier
{
    [SerializeField] private int strengthModifier;
    [SerializeField] private int defenseModifier;
    [SerializeField] private int speedModifier;
    [SerializeField] private int accuracyModifier;

    public override void ApplyStatModifiers(EntityAttributes attributes)
    {
        attributes.pStrength += strengthModifier;
        attributes.pDefense += defenseModifier;
        attributes.pSpeed += speedModifier;
        attributes.pAccuracy += accuracyModifier;
    }

    public override void RemoveStatModifiers(EntityAttributes attributes)
    {
        attributes.pStrength -= strengthModifier;
        attributes.pDefense -= defenseModifier;
        attributes.pSpeed -= speedModifier;
        attributes.pAccuracy -= accuracyModifier;
    }

}