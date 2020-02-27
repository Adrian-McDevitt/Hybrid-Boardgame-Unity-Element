using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swap_Cost_Increment : MonoBehaviour {

    public Text swapPriceText;

    public string priceName;
    public int currentPrice;
	// Use this for initialization
	void Start ()
    {
        swapPriceText.text = priceName + " " + currentPrice.ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
        swapPriceText.text = priceName + " " + currentPrice.ToString();
    }
}
