using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCheck : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Direita") || col.CompareTag("Esquerda") || col.CompareTag("Centro"))
        {
            return;
        }

        if (col.GetComponent<SpriteRenderer>().color == gameObject.GetComponent<SpriteRenderer>().color)
        {
            Destroy(col.gameObject);
            main.POINTS += 1;
        }

        else
        {
            main.POINTS -= 1;
        }
    }
}
