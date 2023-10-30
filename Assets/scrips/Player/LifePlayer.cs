using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    public TextMeshProUGUI text;

    public int life;

    private void Update()
    {
        text.SetText("Vidas: "+ life.ToString());
    }

    public void LifeChange(int value)
    {
        life -= value;
        if(life <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            LifeChange(1);
            collision.GetComponent<LifeEnemy>().life -= 1;
        }
    }
}
