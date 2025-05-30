using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hand 2 Hand", menuName = "Items/Weapons/Melee/Hand 2 Hand")]
public class HandHandData : MeleeWeaponData, IStatModifier
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