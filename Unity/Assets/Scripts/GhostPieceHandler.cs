using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPieceHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject gameHandler;

    private Sprite RedGhostA, BlueGhostA, YellowGhostA;
    private Sprite RedGhostB, BlueGhostB, YellowGhostB;

    // Start is called before the first frame update
    public void SetupGhostPiece()
    {
        switch (this.name)
        {
            case "RedGhostA":
                this.GetComponent<SpriteRenderer>().sprite = RedGhostA;
                break;

            case "BlueGhostA":
                this.GetComponent<SpriteRenderer>().sprite = BlueGhostA;
                break;

            case "YellowGhostA":
                this.GetComponent<SpriteRenderer>().sprite = YellowGhostA;
                break;

            case "RedGhostB":
                this.GetComponent<SpriteRenderer>().sprite = RedGhostB;
                break;

            case "BlueGhostB":
                this.GetComponent<SpriteRenderer>().sprite = BlueGhostB;
                break;

            case "YellowGhostB":
                this.GetComponent<SpriteRenderer>().sprite = YellowGhostB;
                break;

            default:
                break;
        }
    }


}
