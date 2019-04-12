using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

// Level - Progrssion Tracking

// This class is intended to provide methods for returning level specific data
// EACH LEVEL SHOULD HAVE ITS OWN UNIQUE Level.cs

public class Level : MonoBehaviour
{
  public string[] instructions;
  // Start is called before the first frame update
  void Start() {
    instructions = new string[]{
      "Step 1: Press the 'Y' button to proceed to the next step.\n",
      "Step 2: For this step, press the 'Y' button.\n",
      "Step 3: Do you wish to continue this tutorial? Y/Y\n",
      "Step 4: You'll need to press 'Y' again to finish this tutorial.\n",
      "Step 5: I lied. But this time for real. Press 'Y' just one more time.\n",
      "Congratulations! A winner is you!"
    };
  }

  public bool stepCompleted() {
    return SteamVR_Actions._default.TopButton.GetStateUp(SteamVR_Input_Sources.Any);
  }

// Update is called once per frame
  void Update() {

  }
}
