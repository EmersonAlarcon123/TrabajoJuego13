using UnityEngine;
using TMPro;

public class Collector : MonoBehaviour
{
    public TextMeshProUGUI text;

    public int total;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Item"))
        {
            int value = collision.gameObject.GetComponent<Coin>().amount;
            
            Destroy(collision.gameObject);

            total += value;
            text.SetText(total.ToString());
        }
    }
}