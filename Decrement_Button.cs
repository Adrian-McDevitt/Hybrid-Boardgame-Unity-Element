using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decrement_Button : MonoBehaviour {

    public Button buttonObject;

    public Swap_Cost_Increment Swap_Cost_Increment;

    public int currentCost = 1;

    public void Decrement ()
    {
        Swap_Cost_Increment.currentPrice -= currentCost;
    }

}
