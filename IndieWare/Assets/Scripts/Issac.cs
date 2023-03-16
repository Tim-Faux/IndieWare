using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Issac : MonoBehaviour
{
	int IssacPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.A) && IssacPos > -1) {
			transform.position = new Vector2(transform.position.x - 5, transform.position.y);
			IssacPos--;
		}
		if (Input.GetKeyDown(KeyCode.D) && IssacPos < 1) {
			transform.position = new Vector2(transform.position.x + 5, transform.position.y);
			IssacPos++;
		}
	}
}
