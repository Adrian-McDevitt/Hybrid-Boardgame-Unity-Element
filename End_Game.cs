using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_Game : MonoBehaviour {

    public void QuitGame ()
    {
        Debug.Log("The game has ended");
        Application.Quit();
    }
    
}
