using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseSpell : MonoBehaviour {

    public float spellDamage;

    public enum SpellType
    {
        EnhancerType,
        ConjurerType,
        ElementalistType,
        FaiberType,
        ManipulatorType,
        UnknownType
    }

    public SpellType spellType;
}
