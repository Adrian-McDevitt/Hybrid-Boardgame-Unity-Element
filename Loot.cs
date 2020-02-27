using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loot : MonoBehaviour {

    public GameObject Textbox;
    public int LootNum;

	// Use this for initialization
	public void RandomGenerate ()
    {
        LootNum = Random.Range(1, 10);

        switch(LootNum)
        {
            case 1:
            case 2:
                Textbox.GetComponent<Text>().text = "Trap";
                break;

            case 3:
            case 4:
                Textbox.GetComponent<Text>().text = "Blank";
                break;

            case 5:
            case 6:
                Textbox.GetComponent<Text>().text = "Action";
                break;

            case 7:
            case 8:
                Textbox.GetComponent<Text>().text = "-1 Gold";
                break;

            case 9:
                Textbox.GetComponent<Text>().text = "-2 Gold";
                break;

            default:
                break;


        }

    }
	
	
}
