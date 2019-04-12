using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

// This class is intended to provide methods for returning level specific data
// EACH LEVEL SHOULD HAVE ITS OWN UNIQUE Level.cs

public class Level : MonoBehaviour
{
  public string[] instructions;
  // Start is called before the first frame update
  void Start() {
    instructions = new string[]{
      "Step 1: Do the thing. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\n",
      "Step 2: Aliquam hendrerit imperdiet erat id consequat.\n",
      "Step 3: Duis est enim, commodo sollicitudin suscipit a, aliquam et purus.\n",
      "Step 4: Praesent gravida, mi in ultrices eleifend, augue turpis porta erat, eget malesuada lacus risus pharetra orci.\n",
      "Step 5: Quisque pellentesque facilisis ipsum, a dignissim leo pharetra eget.\n",
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
