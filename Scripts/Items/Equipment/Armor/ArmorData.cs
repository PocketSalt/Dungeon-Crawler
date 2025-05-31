using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArmorData : EquipableItem
{
    public override EquipmentSlot Slot { get; }
}

[CreateAssetMenu(menuName = "Items/Armor/Head")]
public class HeadGearData : ArmorData
{
    public override EquipmentSlot Slot => EquipmentSlot.Head;
}

[CreateAssetMenu(menuName = "Items/Armor/Body")]
public class BodyGearData : ArmorData
{
    public override EquipmentSlot Slot => EquipmentSlot.Body;
}

[CreateAssetMenu(menuName = "Items/Armor/Legs")]
public class LegGearData : ArmorData
{
    public override EquipmentSlot Slot => EquipmentSlot.Leg;
}