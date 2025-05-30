using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New HeadGear", menuName = "Items/Armor/Headgear")]
public class HeadArmorData : WeaponData
{
    public override EquipmentSlot Slot => EquipmentSlot.Head;
}