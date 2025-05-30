using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New One Handed Sword", menuName = "Items/Weapons/Melee/One Handed Sword")]
public class OneHandedSwordData : MeleeWeaponData, IStatModifier
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