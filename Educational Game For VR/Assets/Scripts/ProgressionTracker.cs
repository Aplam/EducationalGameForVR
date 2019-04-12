using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class ProgressionTracker : MonoBehaviour {
  public SteamVR_Action_Boolean topButton;
  public Text stepText;
  public AudioSource progressAudio;
  private int stepCount;
  private static string[] instructions = new string[]{
    "Step 1: Do the thing. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\n",
    "Step 2: Aliquam hendrerit imperdiet erat id consequat.\n",
    "Step 3: Duis est enim, commodo sollicitudin suscipit a, aliquam et purus.\n",
    "Step 4: Praesent gravida, mi in ultrices eleifend, augue turpis porta erat, eget malesuada lacus risus pharetra orci.\n",
    "Step 5: Quisque pellentesque facilisis ipsum, a dignissim leo pharetra eget.\n",
    "Congratulations! A winner is you!"
  };
  // Start is called before the first frame update
  void Start() {
    stepCount = 0;
    stepText.text = instructions[stepCount];
  }
  // Call NextStep once a step is completed to update the stepCount and show the player the next step
  void NextStep() {
    if(stepCount < instructions.Length - 1) {
      stepCount += 1;
      stepText.text += instructions[stepCount];
      progressAudio.Play();
    }
  }

  // Update is called once per frame
  void Update() {
    if(SteamVR_Actions._default.TopButton.GetStateUp(SteamVR_Input_Sources.Any)) {
      NextStep();
    }
  }
}
