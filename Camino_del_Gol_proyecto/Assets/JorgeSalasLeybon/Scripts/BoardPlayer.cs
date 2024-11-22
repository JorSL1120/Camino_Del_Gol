using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using UnityEngine;

public class BoardPlayer : Board
{
    int posx, posy;

    void initBoard()
    {
        base.initBoard();

        // calcular center
        float temp = size;
        posx = Mathf.FloorToInt(temp / 2);
        posy = 0;

        tablero[posx, posy] = 2;
    }

    public void moveLeft()
    {

    }

    public bool CanMoveLeft()
    {
        if(posx == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
