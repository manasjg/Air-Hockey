using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
    Vector3 paddlePos;
    private pos1 P1;
    private pos2 P2;
    
	// Use this for initialization
	void Start () {
      P1 = GameObject.FindObjectOfType<pos1>();
        P2 = GameObject.FindObjectOfType<pos2>();
        if (this.transform.position == P1.transform.position)
        {
            paddlePos.x = Mathf.Clamp(paddlePos.x, 0.1f, 10f);
            paddlePos.y = Mathf.Clamp(paddlePos.y, -3.64f, 3.64f);

        } 
		else if (this.transform.position == P2.transform.position)
        {
            paddlePos.x = Mathf.Clamp(paddlePos.x, -10f, 0.1f);
            paddlePos.y = Mathf.Clamp(paddlePos.y, -3.64f, 3.64f);

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }
        var x = Input.GetAxis("Horizontal")*0.1f;
        var y = Input.GetAxis("Vertical")*0.1f;
        transform.Translate(x, y, 0);
        paddlePos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        paddlePos.z = 0;
        this.transform.position = paddlePos;

	}
}
