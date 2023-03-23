using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomsFoot : MonoBehaviour
{
	[SerializeField]
	public const float TimeBetweenStomps = 3;
	private const float FootStartXPos = 5;
	private const float FootStartYPos = 9;
	private float timeRemaining = TimeBetweenStomps;
	private bool timerIsRunning = true;
	// Start is called before the first frame update
	void Start()
    {
		transform.position = SelectFootPos();
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

	public Vector2 SelectFootPos()
	{
		return new Vector2(FootStartXPos + (Random.Range(-1, 1) * 5), FootStartYPos);
	}
}
