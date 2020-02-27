using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour {

    
    public GameObject Textbox;
    public int EventNum;

    // Use this for initialization
    public void RandomGenerate()
    {
        EventNum = Random.Range(1, 21);

        switch (EventNum)
        {
            case 1:
            case 2:
                Textbox.GetComponent<Text>().text = "Swap Places (Person to your left)";
                break;

            case 3:
            case 4:
                Textbox.GetComponent<Text>().text = "Swap Places (Person to your right)";
                break;

            case 5:
            case 6:
                Textbox.GetComponent<Text>().text = "All -2 Gold";
                break;

            case 7:
                Textbox.GetComponent<Text>().text = "All +2 Gold";
                break;

            case 8:
            case 9:
     
                Textbox.GetComponent<Text>().text = "Go back to spawn (solo)";
                break;

            case 10:
            case 11:
            case 12:
                Textbox.GetComponent<Text>().text = "Give 1 Gold to other players";
                break;

            case 13:
                Textbox.GetComponent<Text>().text = "Give 2 Gold to other players";
                break;

            case 14:
                Textbox.GetComponent<Text>().text = "Lose one Item";
                break;

            case 15:
            case 16:
            case 17:
                Textbox.GetComponent<Text>().text = "Replace Last Tile Touched";
                break;

            case 18:
                Textbox.GetComponent<Text>().text = "Replace Tiles touching Event";
                break;

            case 19:
                Textbox.GetComponent<Text>().text = "Replace Tile of choice";
                break;

            case 20:
                Textbox.GetComponent<Text>().text = "+1 Move";
                break;

            default:
                break;


        }

    }


}
