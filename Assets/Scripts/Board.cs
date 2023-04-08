using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private int width;//ancho
    [SerializeField] private int height;//alto
    [SerializeField] private GameObject tileObject;
    [SerializeField] private float cameraSizeOffset;
    [SerializeField] private float cameraVerticalOffset;
    // Start is called before the first frame update
    void Start()
    {
        SetupBoard();
        PositionCamera();
    }

    private void PositionCamera()
    {
        float newPosX = (float)width / 2f;
        float newPosY = (float)height / 2f;

        Camera.main.transform.position= new Vector3 (newPosX-0.5f, newPosY-0.5f+cameraVerticalOffset, -10);

        float horizontal = width + 1;
        float vertical = (height/2)+1;

        Camera.main.orthographicSize= horizontal>vertical?horizontal+cameraSizeOffset:vertical+cameraSizeOffset;
    }

    private void SetupBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                var o = Instantiate(tileObject, new Vector3(x, y, -5), Quaternion.identity);
                o.transform.parent = transform;
                o.GetComponent<Tile>()?.Setup(x, y, this);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
