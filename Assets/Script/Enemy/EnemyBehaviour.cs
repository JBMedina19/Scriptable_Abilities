using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int health;
    public GameObject FloatingTextDMG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (FloatingTextDMG)
        {
            FloatingText(damage);
        }
    }
    public void FloatingText(int damage)
    {
        Vector3 offset = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        offset.y += Random.Range(1, 3);
        offset.x += Random.Range(-1, 1);
        offset.z += Random.Range(-1, 1);

        var go = Instantiate(FloatingTextDMG, offset, Quaternion.identity);
        go.GetComponent<TextMeshPro>().text = damage.ToString();
    }
}
