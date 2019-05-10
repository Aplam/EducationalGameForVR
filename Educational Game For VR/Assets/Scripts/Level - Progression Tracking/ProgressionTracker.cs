using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressionTracker : MonoBehaviour {
	// stepText: the worldspace Text object where instructions will be displayed to the player
	public Text stepText;

	// progressAudio: the Audio Source object that will indicate to the player that a step has been completed
	public AudioSource progressAudio;

	// level: The Level object associated with the current level
	public Level level;

	// stepCount: The current step the player is on (0 indexed, 0 = 'Step 1')
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
		if(level.stepCompleted()) {
			NextStep();
		}
	}
}
