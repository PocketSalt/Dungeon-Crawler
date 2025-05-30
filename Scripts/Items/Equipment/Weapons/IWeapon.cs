using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon : IEquipable
{
    void NormalAttack();
    void HeavyAttack();
}
