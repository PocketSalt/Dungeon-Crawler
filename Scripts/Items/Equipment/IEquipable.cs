using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEquipable
{
    string ItemName { get; }
    EquipmentSlot Slot { get; }
}
