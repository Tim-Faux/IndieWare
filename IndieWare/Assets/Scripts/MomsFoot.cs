using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomsFoot : MonoBehaviour
{
	[SerializeField]
	float TimeBetweenStomps;
	[SerializeField]
	float LengthOfStomp;
	private const float FootMiddleXPos = 0;
	private const float FootStartYPos = 9;
	private const float FootStompYPos = 2;
	private float timeRemaining;
	private float stompTimeRemaining;
	private int? previousFootPos;
	// Start is called before the first frame update
	void Start()
    {
		transform.position = SelectFootPos();
		timeRemaining = TimeBetweenStomps;
		stompTimeRemaining = LengthOfStomp;
		var momsShadow = GameObject.Find("Mom's Shadow");
		momsShadow.transform.position = new Vector2(transform.position.x, momsShadow.transform.position.y);
	}

    // Update is called once per frame
    void Update()
    {
		var issac = GameObject.Find("Issac");
		if (timeRemaining > 0) {
			timeRemaining -= Time.deltaTime;
		}
		else if(issac != null && issac.transform.position.x == transform.position.x) {
			transform.position = new Vector2(transform.position.x, FootStompYPos);
			Destroy(issac);
		}
		else {
			transform.position = new Vector2(transform.position.x, FootStompYPos);
			if (stompTimeRemaining > 0) {
				stompTimeRemaining -= Time.deltaTime;
			}
			else {
				stompTimeRemaining = LengthOfStomp;
				timeRemaining = TimeBetweenStomps;
				transform.position = SelectFootPos();
				var momsShadow = GameObject.Find("Mom's Shadow");
				momsShadow.transform.position = new Vector2(transform.position.x, momsShadow.transform.position.y);
			}
		}
	}

	// Select one of 3 positions for the foot 
	public Vector2 SelectFootPos()
	{
		var randPos = Random.Range(-1, 2);
		while (randPos == previousFootPos) {
			randPos = Random.Range(-1, 2);
		}
		previousFootPos = randPos;
		return new Vector2(FootMiddleXPos + (randPos * 5), FootStartYPos);
	}
}
