using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomsFoot : MonoBehaviour
{
	[SerializeField]
	public const float TimeBetweenStomps = 3;
	private float timeRemaining = TimeBetweenStomps;
	private bool timerIsRunning = true;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (timerIsRunning) {
			if (timeRemaining > 0) {
				timeRemaining -= Time.deltaTime;
			}
			else {
				Debug.Log("Time has run out!");
				timeRemaining = 0;
				timerIsRunning = false;
				//rerandomize foot position
			}
		}
	}
}
