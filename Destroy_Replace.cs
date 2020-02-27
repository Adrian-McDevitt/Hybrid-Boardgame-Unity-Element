using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Destroy_Replace : MonoBehaviour {

    // Use this for initialization
    public GameObject Textbox;
    public int RandPlayer;



    public void RandomGenerate()
    {
        RandPlayer = Random.Range(1, 7);

        switch (RandPlayer)
        {
            case 1:

                Textbox.GetComponent<Text>().text = "Player " + RandPlayer + " pick which tile to replace/destroy";
                break;

            case 2:

                Textbox.GetComponent<Text>().text = "Player " + RandPlayer + " pick which tile to replace/destroy";
                break;

            case 3:

                Textbox.GetComponent<Text>().text = "Player " + RandPlayer + " pick which tile to replace/destroy";
                break;

            case 4:

                Textbox.GetComponent<Text>().text = "Player " + RandPlayer + " pick which tile to replace/destroy";
                break;

            case 5:

                Textbox.GetComponent<Text>().text = "Player " + RandPlayer + " pick which tile to replace/destroy";
                break;

            case 6:

                Textbox.GetComponent<Text>().text = "Player " + RandPlayer + " pick which tile to replace/destroy";
                break;
        }
    }
}
