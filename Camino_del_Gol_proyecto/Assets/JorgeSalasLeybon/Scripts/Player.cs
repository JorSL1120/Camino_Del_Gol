using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    BoardPlayer board;
    public GameObject space;

    private Animator animator;
    private bool seMovio = false;

    public float lenX = 1f, lenY = 1f;

    GameObject[,] goBoard;

    void Awake()
    {
        board = new BoardPlayer();

        goBoard = new GameObject[board.getSize(), board.getSize()];

        for (int j = 0; j < board.getSize(); j++)
        {
            for (int i = 0; i < board.getSize(); i++)
            {
                goBoard[i, j] = GameObject.Instantiate(space, transform);
                //goBoard[i, j].GetComponent<SpriteRenderer>().color = Color.black;
            }
        }

        updateGuiSprite();
        updateGuiPosition();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(board);
        }
        animator.SetBool("Mov", seMovio);
    }

    public void updateGuiPosition()
    {
        for (int j = 0; j < board.getSize(); j++)
        {
            for (int i = 0; i < board.getSize(); i++)
            {
                Vector2 pos = Vector2.zero;
                pos.x = i * lenX; pos.y = j * lenY;
                goBoard[i, j].transform.localPosition = pos;
            }
        }
    }

    public void updateGuiSprite()
    {
        for (int j = 0; j < board.getSize(); j++)
        {
            for (int i = 0; i < board.getSize(); i++)
            {
                if (board.getFromBoard(i, j) == 0)
                {
                    goBoard[i, j].SetActive(false);
                }
                else
                {
                    goBoard[i, j].SetActive(true);
                }
            }
        }
    }

    public void moveRight()
    {
        board.moveRight();
        seMovio = true;
        StartCoroutine(WalkFalse());
    }

    public void moveLeft()
    {
        board.moveLeft();
        seMovio = true;
        StartCoroutine(WalkFalse());
    }

    public void moveUp()
    {
        board.moveUp();
        seMovio = true;
        StartCoroutine(WalkFalse());
    }

    public void moveDown()
    {
        board.moveDown();
        seMovio = true;
        StartCoroutine(WalkFalse());
    }

    public Vector2Int getPosPlayer()
    {
        return board.getPos();
    }

    IEnumerator WalkFalse()
    {
        yield return new WaitForSeconds(1f);
        seMovio = false;
    }
}
