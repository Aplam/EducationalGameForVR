using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using System.IO;

// Level - Progrssion Tracking

// This class is intended to provide methods for returning level specific data
// EACH LEVEL SHOULD HAVE ITS OWN UNIQUE Level.cs

public class LevelFlashcard : MonoBehaviour
{
  public string[] frontText;
  public string[] backText;
  // Start is called before the first frame update
  void Start() {
    // TODO: Read in frontText and backText values from CSV
  }

  public bool stepCompleted() {
    return SteamVR_Actions._default.TopButton.GetStateUp(SteamVR_Input_Sources.Any);
  }

// Update is called once per frame
  void Update() {

  }
}
