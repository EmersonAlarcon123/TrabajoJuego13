using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    public TextMeshProUGUI text;

    public int total;

    private void Update()
    {
        CondicionDeVictoria();
    }

    void CondicionDeVictoria()
    {
        if(total >= 10)
        {
            SceneManager.LoadScene(3);
        }
    }

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