using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject prefabCoin;

    private void Awake()
    {
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(prefabCoin, transform.position, transform.rotation);
        yield return new WaitForSeconds(3.5f);
        StartCoroutine(Generate());
    }
}
