using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Piece : MonoBehaviour
{

    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private Board board;

    public enum type
    {
        blue,
        brownie,
        canela,
        capuccino,
        cleopatra,
        felix,
        jupiter,
        kiara,
        moshi,
        pecos,
    }
    public type pieceType;

    public void Setup(int x_, int y_, Board board_)
    {
        this.x = x_;
        this.y = y_;
        board = board_;
    }

    public void Move(int desX, int desY)
    {
        transform.DOMove(new Vector3(desX, desY, -5), 0.25f).SetEase(Ease.InOutCubic).onComplete = ()=>
        {
            x = desX;
            y= desY;
        };
    }
    [ContextMenu("Test Move")]
    public void MoveTest()
    {
        Move(0,0);
    }
}
