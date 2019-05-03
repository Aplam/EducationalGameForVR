using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashcardProgressionTracker : MonoBehaviour {
  // the worldspace Text objects where flashcard text will be displayed to the player
  public Text cardFront;
  public Text cardBack;
  public Text randomizerButton;
  // progressAudio: the Audio Source object that will indicate to the player that a step has been completed
  public AudioSource progressAudio;
  // level: The Level object associated with the current level
  public LevelFlashcard level;
  // stepCount: The current step the player is on (0 indexed, 0 = 'Step 1')
  private int stepCount;
  private bool randomize;
  private List<int> learned = new List<int>();
  // Start is called before the first frame update
  void Start() {
    stepCount = -1;
    cardFront.text = "This is the Omnicard.\n\nThis side is the front...";
    cardBack.text = "... and this side is the back. Press \'Y\' to start studying your custom flashcards! After you're finished reviewing a card, press \'Y\' to keep the current card in the rotation and proceed to the next or press \'X\' to mark the current card as 'learned' which will remove it from the rotation.\n\nGood luck; have fun!";
    randomizerButton.text = "Randomizer\nOff";
    randomize = false;
  }
  // Call NextStep once a step is completed to update the stepCount and show the player the next step
  void NextStep() {
    if (level.frontText.Length == learned.Count) {
      cardFront.text = "You\'ve learned all of your flashcards!";
      cardBack.text = "Congratulations!";
      progressAudio.Play();
    }
    else if (randomize) {
      int prevStep = stepCount;
      while (stepCount == prevStep && learned.Contains(stepCount)) {
        stepCount = Random.Range(0,level.frontText.Length);
      }
      cardFront.text = level.frontText[stepCount];
      cardBack.text = level.backText[stepCount];
      progressAudio.Play();
    }
    else {
      stepCount += 1;
      while (learned.Contains(stepCount)) {
        stepCount += 1;
        Debug.Log("Skipping a card");
      }
      if (stepCount == level.frontText.Length) {
        stepCount = 0;
      }
      cardFront.text = level.frontText[stepCount];
      cardBack.text = level.backText[stepCount];
      progressAudio.Play();
    }

  }
  public void ToggleRandom() {
    randomize = !randomize;
    if (randomize) {
      randomizerButton.text = "Randomizer\nOn";
    }
    else {
      randomizerButton.text = "Randomizer\nOff";
    }
  }
  // Update is called once per frame
  void Update() {
    if(level.stepCompleted()) {
      NextStep();
    }
    if(level.cardLearned()) {
      if (stepCount != -1 ) {
        learned.Add(stepCount);
      }
      NextStep();
      Debug.Log("###################################");
      Debug.Log(level.frontText.Length);
      Debug.Log(learned.Count);
      foreach (var card in learned) {
        Debug.Log(card);
      }
    }
  }
}
