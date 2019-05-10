using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

// sandwich - Progrssion Tracking

// This class is intended to provide methods for returning level specific data
// EACH LEVEL SHOULD HAVE ITS OWN UNIQUE Level.cs

public class sandwichSteps : MonoBehaviour
{
    public string[] instruct;
    // Start is called before the first frame update
    void Start()
    {
        instruct = new string[]{
        "Step 1: Retrieve the bread and place it on the gray cutting board.\n",
        "Step 2: Retrieve the ham and place it on the cutting board.\n",
        "Step 3: Retrieve the cheese and place it on the cutting board.\n",
        "Step 4: Retrieve the tomato and place it on the board.\n",
        "Step 5: Retrieve the lettuce and place it on the board.\n",
        "Congratulations! A sandwich is yours!"
         };
    }
		
    public bool stepCompleted()
    {
        return SteamVR_Actions._default.TopButton.GetStateUp(SteamVR_Input_Sources.Any);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
