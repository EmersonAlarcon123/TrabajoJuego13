using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedas : MonoBehaviour
{
    public int moneda = 1;
    
    public void Awake()
    {
        Destroy(gameObject,2);
    }
}



