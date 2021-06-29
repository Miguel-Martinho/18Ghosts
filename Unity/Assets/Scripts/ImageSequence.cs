using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSequence : MonoBehaviour
{
    // https://answers.unity.com/questions/439494/draw-a-pixel-and-change-its-color-in-code.html
    [SerializeField]
    private Texture2D board;
    private int sizeX = 10;
    private int sizeY = 10;
    private int random;
    private void Awake()
    {
        sizeX = Screen.width;
        sizeY = Screen.height;
        board = new Texture2D(sizeX, sizeY);
    }

    private void ChangeTheColor(Color c)
    {
        for (int x = 0; x < sizeX / 2; x++)
            for (int y = 0; y < sizeY / 2; y++)
            { 
                random = Random.Range(0, sizeX / 2);
                board.SetPixel(random, y, c);
            }
        board.Apply();
    }
    private void Update()
    {
        ChangeTheColor(Color.red);
        ChangeTheColor(Color.blue);
        ChangeTheColor(Color.green);
    }

    private void OnGUI()
    {
        GUILayout.Label(board);
    }
}
