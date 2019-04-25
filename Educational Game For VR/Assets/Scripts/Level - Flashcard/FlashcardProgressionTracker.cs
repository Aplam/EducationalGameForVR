using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashcardProgressionTracker : MonoBehaviour {
  // the worldspace Text objects where flashcard text will be displayed to the player
  public Text cardFront;
  public Text cardBack;
  // progressAudio: the Audio Source object that will indicate to the player that a step has been completed
  public AudioSource progressAudio;
  // level: The Level object associated with the current level
  public LevelFlashcard level;
  // stepCount: The current step the player is on (0 indexed, 0 = 'Step 1')
  private int stepCount;
  // Start is called before the first frame update
  void Start() {
    stepCount = 0;
    cardFront.text = "This is the Omnicard.\n\nThis side is the front...";
    cardBack.text = "... and this side is the back.\n\nPress \'Y\' to start studying your custom flashcards!\n\nAfter you're finished reviewing a card, press \'Y\' to proceed to the next.\n\nGood luck; have fun!";
  }
  // Call NextStep once a step is completed to update the stepCount and show the player the next step
  void NextStep() {
    if (stepCount == level.frontText.Length) {
      stepCount = 0;
    }
    cardFront.text = level.frontText[stepCount];
    cardBack.text = level.backText[stepCount];
    stepCount += 1;
    progressAudio.Play();
  }
  // Update is called once per frame
  void Update() {
    if(level.stepCompleted()) {
      NextStep();
    }
  }
}
