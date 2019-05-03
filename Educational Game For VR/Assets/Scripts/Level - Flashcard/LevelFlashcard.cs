using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

// Level - Flashcard

// This class is intended to provide methods for returning level specific data
// EACH LEVEL SHOULD HAVE ITS OWN UNIQUE Level.cs

public class LevelFlashcard : MonoBehaviour
{
  public string[] frontText;
  public string[] backText;
  public List<string> frontTextList = new List<string>();
  public List<string> backTextList = new List<string>();
  public TextAsset cSVFile;

  // Start is called before the first frame update
  void Start() {
    List<string> frontTextList = new List<string>();
    List<string> backTextList = new List<string>();
    string[] cSVLines = cSVFile.text.Split ('\n');
    foreach (string line in cSVLines) {
      string[] entries = line.Split (',');
      if (entries.Length >= 2) {
        frontTextList.Add(entries[0]);
        backTextList.Add(entries[1]);
      }
    }
    frontText = frontTextList.ToArray();
    backText = backTextList.ToArray();
  }

  public bool stepCompleted() {
    return SteamVR_Actions._default.TopButton.GetStateUp(SteamVR_Input_Sources.Any);
  }

  public bool cardLearned() {
    return SteamVR_Actions._default.XButton.GetStateUp(SteamVR_Input_Sources.Any);
  }

  void Update() {

  }
}
