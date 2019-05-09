using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using System.IO;

public class LevelFlashcard : MonoBehaviour
{
  // worldspace Text objects
  public Text cardFrontText;
  public Text cardBackText;
  public Text randomizerButtonText;
  public Text selDeckText;
  // worldspace Audio Source objects
  public AudioSource progressAudioSource;
  // the current step the player is on (0 indexed, 0 = 'Step 1')
  private int stepCount;
  // True when card randomization is enabled
  private bool randomize;
  // The string arrays that hold the front and back text for the current flashcard deck
  private string[] frontTextArr;
  private string[] backTextArr;
  // The array of file info that reperesents all the CSV files found in '.../StreamingAssets/flashcards'
  private FileInfo[] allCSVs;
  // The index of the currently selected deck within allCSVs. (Note, this is the currently selected deck, not necessarily the deck currently displayed on the flashcards)
  private int curDeckIndex = 0;
  // The list of learned cards in the current deck represented by their index value within the deck
  private List<int> learned = new List<int>();

  // Start is called before the first frame update
  void Start() {
    DirectoryInfo csvDirInfo = new DirectoryInfo(Application.streamingAssetsPath + "/flashcards");
    allCSVs = csvDirInfo.GetFiles("*.csv");
    changeDeck();
    selDeckText.text = Path.GetFileNameWithoutExtension(allCSVs[curDeckIndex].Name);
    stepCount = -1;
    cardFrontText.text = "This is the Omnicard.\n\nThis side is the front...";
    cardBackText.text = "... and this side is the back. Press \'Y\' to start studying your custom flashcards! After you're finished reviewing a card, press \'Y\' to keep the current card in the rotation and proceed to the next or press \'X\' to mark the current card as 'learned' which will remove it from the rotation.\n\nGood luck; have fun!";
    randomizerButtonText.text = "Randomizer\nOff";
    randomize = false;
  }

  public bool stepCompleted() {
    return SteamVR_Actions._default.TopButton.GetStateUp(SteamVR_Input_Sources.Any);
  }

  void NextStep() {
    if (frontTextArr.Length == learned.Count) {
      cardFrontText.text = "You\'ve learned all of your flashcards!";
      cardBackText.text = "Congratulations!";
      progressAudioSource.Play();
    }
    else if (randomize) {
      int prevStep = stepCount;
      while (stepCount == prevStep && learned.Contains(stepCount)) {
        stepCount = Random.Range(0,frontTextArr.Length);
      }
      cardFrontText.text = frontTextArr[stepCount];
      cardBackText.text = backTextArr[stepCount];
      progressAudioSource.Play();
    }
    else {
      stepCount += 1;
      while (learned.Contains(stepCount)) {
        stepCount += 1;
      }
      if (stepCount == frontTextArr.Length) {
        stepCount = 0;
      }
      cardFrontText.text = frontTextArr[stepCount];
      cardBackText.text = backTextArr[stepCount];
      progressAudioSource.Play();
    }
  }

  public void ToggleRandom() {
    randomize = !randomize;
    if (randomize) {
      randomizerButtonText.text = "Randomizer\nOn";
    }
    else {
      randomizerButtonText.text = "Randomizer\nOff";
    }
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
    frontTextArr = frontTextList.ToArray();
    backTextArr = backTextList.ToArray();
    progressAudioSource.Play();
    // reset the list of learned flashcards for the newly selected deck
    learned = new List<int>();
  }

  public void selPrevDeck() {
    curDeckIndex -= 1;
    if (curDeckIndex == -1) {
      curDeckIndex = allCSVs.Length - 1;
    }
    selDeckText.text = Path.GetFileNameWithoutExtension(allCSVs[curDeckIndex].Name);
  }

  public void selNextDeck() {
    curDeckIndex += 1;
    if (curDeckIndex == allCSVs.Length) {
      curDeckIndex = 0;
    }
    selDeckText.text = Path.GetFileNameWithoutExtension(allCSVs[curDeckIndex].Name);
  }

  void Update() {
    if(stepCompleted()) {
      NextStep();
    }
    if(cardLearned()) {
      if (stepCount != -1 ) {
        learned.Add(stepCount);
      }
      NextStep();
    }
  }
}
