using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDeleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Direita") || col.CompareTag("Esquerda") || col.CompareTag("Centro"))
            return;

        else if (col.CompareTag("Wall"))
            col.gameObject.SetActive(false);
    }
}
