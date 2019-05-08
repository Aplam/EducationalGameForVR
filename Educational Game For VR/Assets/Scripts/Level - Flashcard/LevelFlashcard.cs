using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using System.IO;

// Level - Flashcard

// This class is intended to provide methods for returning level specific data
// EACH LEVEL SHOULD HAVE ITS OWN UNIQUE Level.cs

public class LevelFlashcard : MonoBehaviour
{
  public string[] frontText;
  public string[] backText;
  private FileInfo[] allCSVs;
  private int curDeckIndex = 0;

  // Start is called before the first frame update
  void Start() {
    DirectoryInfo csvDirInfo = new DirectoryInfo(Application.streamingAssetsPath + "/flashcards");
    allCSVs = csvDirInfo.GetFiles("*.csv");
    changeDeck();
  }

  public bool stepCompleted() {
    return SteamVR_Actions._default.TopButton.GetStateUp(SteamVR_Input_Sources.Any);
  }

  public bool cardLearned() {
    return SteamVR_Actions._default.XButton.GetStateUp(SteamVR_Input_Sources.Any);
  }

  public void changeDeck() {
    StreamReader newDeck = allCSVs[curDeckIndex].OpenText();
    List<string> frontTextList = new List<string>();
    List<string> backTextList = new List<string>();
    string line;
    while ((line = newDeck.ReadLine()) != null) {
      string[] entries = line.Split (',');
      if (entries.Length >= 2) {
        frontTextList.Add(entries[0]);
        backTextList.Add(entries[1]);
      }
    }
    frontText = frontTextList.ToArray();
    backText = backTextList.ToArray();
  }

  void Update() {

  }
}
