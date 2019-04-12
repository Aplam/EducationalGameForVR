using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class ProgressionTracker : MonoBehaviour {
  public SteamVR_Action_Boolean topButton;
  public Text stepText;
  public AudioSource progressAudio;
  public Level level;
  private int stepCount;
  // Start is called before the first frame update
  void Start() {
    stepCount = 0;
    stepText.text = level.instructions[stepCount];
  }
  // Call NextStep once a step is completed to update the stepCount and show the player the next step
  void NextStep() {
    if(stepCount < level.instructions.Length - 1) {
      stepCount += 1;
      stepText.text += level.instructions[stepCount];
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
