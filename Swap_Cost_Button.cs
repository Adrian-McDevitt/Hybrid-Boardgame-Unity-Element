using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swap_Cost_Button : MonoBehaviour {

    public Button buttonObject;

    public Swap_Cost_Increment Swap_Cost_Increment;

    public int currentCost = 1;

    public void Increment ()
    {
        Swap_Cost_Increment.currentPrice += currentCost;
    }

    public void Decrement()
    {
        Swap_Cost_Increment.currentPrice -= currentCost;
    }


}
