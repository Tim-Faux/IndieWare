using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Issac : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.A)) {
			transform.position = new Vector2(transform.position.x - 5, transform.position.y);
		}
		if (Input.GetKeyDown(KeyCode.D)) {
			transform.position = new Vector2(transform.position.x + 5, transform.position.y);
		}
	}
}
