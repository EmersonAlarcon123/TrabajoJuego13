using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
        if(life < 0)
        {
            Destroy(gameObject);
        }
    }
}
