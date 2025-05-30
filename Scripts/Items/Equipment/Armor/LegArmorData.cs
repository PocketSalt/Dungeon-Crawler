using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New LegGear", menuName = "Items/Armor/Leggear")]
public class LegArmorData : WeaponData
{
    public override EquipmentSlot Slot => EquipmentSlot.Leg;
}