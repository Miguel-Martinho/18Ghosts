using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ghosts.Common;

namespace UnityApp
{
    public class GameHandler : MonoBehaviour
    {
        private GameObject chessPiece;
        private GameObject[] PLayer1Ghosts = new GameObject[9];
        private GameObject[] PLayer2Ghosts = new GameObject[9];


        private Board gameBoard;
        // Start is called before the first frame update
        void Start()
        {
            gameBoard = new Board(5,5);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

