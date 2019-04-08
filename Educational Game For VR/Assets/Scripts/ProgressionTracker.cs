using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressionTracker : MonoBehaviour {

  public Text stepText;
  private int stepCount;
  private static string[] instructions = new string[]{
    "Step 1: Do the thing. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\n",
    "Step 2: Aliquam hendrerit imperdiet erat id consequat.\n",
    "Step 3: Duis est enim, commodo sollicitudin suscipit a, aliquam et purus.\n",
    "Step 4: Praesent gravida, mi in ultrices eleifend, augue turpis porta erat, eget malesuada lacus risus pharetra orci.\n",
    "Step 5: Quisque pellentesque facilisis ipsum, a dignissim leo pharetra eget."
  };
  // Start is called before the first frame update
  void Start() {
    stepCount = 0;
    stepText.text = instructions[stepCount];
  }
  // Call NextStep once a step is completed to update the stepCount and show the player the next step
  void NextStep() {
    stepCount += 1;
    stepText.text += instructions[stepCount];
  }

  // Update is called once per frame
  void Update() {

  }
}
