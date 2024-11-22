using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    BoardPlayer tablero;

    void Awake()
    {
        tablero = new BoardPlayer();
        tablero.initBoard();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(tablero.toString());
        }
    }
}
