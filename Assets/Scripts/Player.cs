using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Singleton
    public static GameObject PLAYER;

    private void Awake()
    {
        PLAYER = gameObject;
    }
    #endregion
}
