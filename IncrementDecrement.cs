using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementDecrement : MonoBehaviour {

    // Use this for initialization
    public int Value = 4;
    public Text TextObject;

    public void Increment()
    {

            ++Value;
            TextObject.text = Value.ToString();

    }

    public void Decrement()
    {
       
        
            --Value;
            TextObject.text = Value.ToString();

    }
}

