using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityStats : MonoBehaviour
{
    public AbilityBehaviour abilityStats;
    int Damage;
    string TargetTag;
    // Start is called before the first frame update
    void Start()
    {
        Damage = abilityStats.Damage;
        TargetTag = abilityStats.Target;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag(TargetTag))
        {
            EnemyBehaviour enemy = other.GetComponent<EnemyBehaviour>();
            enemy.TakeDamage(Damage);
        }
    }
}
