using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float durationText;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, durationText);
    }


}
