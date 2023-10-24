using UnityEngine;

public class Coin : MonoBehaviour
{
    //cantidad de monedas a recolectar
    public int amount;

    private void Awake()
    {
        Destroy(gameObject, 2);
    }
}