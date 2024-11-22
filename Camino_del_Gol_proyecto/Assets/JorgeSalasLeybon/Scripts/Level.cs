using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    Board tablero;

    void Awake()
    {
        tablero = new Board();
        tablero.initBoard();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            tablero.resetBoard();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(tablero.toString());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            tablero.randomBoard();
        }
    }
}
