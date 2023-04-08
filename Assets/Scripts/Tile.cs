using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private Board board;

    public void Setup(int x_,int y_, Board board_)
    {
        this.x = x_;
        this.y = y_;
        board = board_;
    }
}
