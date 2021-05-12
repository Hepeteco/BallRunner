using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    Color[] colors = new Color[3];
    // Start is called before the first frame update
    void Start()
    {
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        gameObject.GetComponent<SpriteRenderer>().color = colors[Random.Range(0, colors.Length)];
    }

}
