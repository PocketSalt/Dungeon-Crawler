using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dual Sword", menuName = "Items/Weapons/Melee/Dual Sword")]
public class DualSwordData : MeleeWeaponData, IStatModifier
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