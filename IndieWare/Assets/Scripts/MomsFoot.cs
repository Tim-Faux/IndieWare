using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomsFoot : MonoBehaviour
{
	[SerializeField]
	public const float TimeBetweenStomps = 3;
	private const float FootMiddleXPos = 0;
	private const float FootStartYPos = 9;
	private float timeRemaining = TimeBetweenStomps;
	// Start is called before the first frame update
	void Start()
    {
		transform.position = SelectFootPos();
	}

    // Update is called once per frame
    void Update()
    {
		if (timeRemaining > 0) {
			timeRemaining -= Time.deltaTime;
		}
		else {
			timeRemaining = TimeBetweenStomps;
			transform.position = SelectFootPos();
		}
	}

	public Vector2 SelectFootPos()
	{
		var temp = Random.Range(-1, 2);
		Debug.Log(temp);
		return new Vector2(FootMiddleXPos + (temp * 5), FootStartYPos);
	}
}
