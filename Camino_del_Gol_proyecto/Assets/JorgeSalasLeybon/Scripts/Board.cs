using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private const int size = 5;
    private const int enemyProb = 2;
    int[,] tablero;

    private void Awake()
    {
        tablero = new int[size, size];
    }

    public void resetBoard()
    {
        for (int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                tablero[i, j] = 0;
            }
        }
    }

    public void randomBoard()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int x = Random.Range(0, 10);
                tablero[i, j] = x <= enemyProb ? 1 : 0;
            }
        }
    }

    public string toString()
    {
        string data = "";

        for (int i = 0;i < size; i++)
        {
            data += "\n";
            for (int j = 0;j < size; j++)
            {
                data += tablero[i, j] == 0 ? "_" : "x";
            }
        }
        return data;
    }

    void Start()
    {
        resetBoard();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            resetBoard();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(toString());
        }

        if( Input.GetKeyDown(KeyCode.R))
        {
            randomBoard();
        }
    }
}
