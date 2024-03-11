using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityHolder : MonoBehaviour
{
    public AbilityBehaviour ability_1;
    public AbilityBehaviour ability_2;
    public AbilityBehaviour ability_3;

    public Image abilityIcon_1;
    public Image abilityIcon_2;
    public Image abilityIcon_3;
    // Start is called before the first frame update
    void Start()
    {
        abilityIcon_1.sprite = ability_1.Icon;
        abilityIcon_2.sprite = ability_2.Icon;
        //abilityIcon_3.sprite = ability_3.Icon;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Ability_Q_Spawner();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Ability_W_Spawner();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }
    public void Ability_Q_Spawner()
    {
        Transform abilitySpawnHere = gameObject.transform;
        if (!ability_1.isProjectile)
        {
            abilitySpawnHere = GameObject.FindGameObjectWithTag("Enemy").transform;
        }
        ParticleSystem fx = Instantiate(ability_1.fx, abilitySpawnHere.position, abilitySpawnHere.rotation);
        AbilityStats abilityStats = fx.GetComponentInChildren<AbilityStats>();
        abilityStats.abilityStats = ability_1;
    }
    public void Ability_W_Spawner()
    {
        Transform abilitySpawnHere = gameObject.transform;
        if (!ability_2.isProjectile)
        {
            abilitySpawnHere = GameObject.FindGameObjectWithTag("Enemy").transform;
        }
        ParticleSystem fx = Instantiate(ability_2.fx, abilitySpawnHere.position, abilitySpawnHere.rotation);
        AbilityStats abilityStats = fx.GetComponentInChildren<AbilityStats>();
        abilityStats.abilityStats = ability_2;
    }
}
