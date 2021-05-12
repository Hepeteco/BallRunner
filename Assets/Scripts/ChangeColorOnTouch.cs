using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnTouch : MonoBehaviour
{
    public GameObject ball;
    private Color color;
    public GameObject selected;
    void Update()
    {
        if(Input.touchCount >= 1)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.touches[0].position), Vector2.zero);

            if(hit.collider != null)
            {
                selected = hit.transform.gameObject;
                if(hit.collider.CompareTag("Direita"))
                {
                    color = Color.blue;
                    ball.GetComponent<SpriteRenderer>().color = color;
                }
                if (hit.collider.CompareTag("Centro"))
                {
                    color = Color.green;
                    ball.GetComponent<SpriteRenderer>().color = color;
                }
                if (hit.collider.CompareTag("Esquerda"))
                {
                    color = Color.red;
                    ball.GetComponent<SpriteRenderer>().color = color;
                }
            }
        }
        
    }
}
