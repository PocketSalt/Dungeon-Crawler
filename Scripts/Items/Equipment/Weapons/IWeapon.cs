using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon : IEquipable
{
    public void NormalAttack();
    public void HeavyAttack();
    public void AoEAttack();
}
