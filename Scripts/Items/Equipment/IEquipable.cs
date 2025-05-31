using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEquipable
{
    string ItemName { get; }
    EquipmentSlot Slot { get; }

    void ApplyStatModifier(EntityAttributes stats);
    void RemoveStatModifier(EntityAttributes stats);
}
