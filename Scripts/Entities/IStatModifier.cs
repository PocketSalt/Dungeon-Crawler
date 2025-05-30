using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStatModifier
{
    void ApplyStatModifiers(EntityAttributes attributes);
    void RemoveStatModifiers(EntityAttributes attributes);
}
