using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Ability", menuName = "NewAbility")]
public class AbilityBehaviour : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite Icon;
    public ParticleSystem fx;
    public string Target;
    public int Damage;
    public int Manacost;
    public int Cooldown;
    public bool isProjectile;
}
