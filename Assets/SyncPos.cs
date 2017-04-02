using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SyncPos : NetworkBehaviour {
    [SyncVar]
    private Vector3 syncPos;

    [SerializeField]
    Rigidbody2D myRigidbody;
    
    [SerializeField]float lerpRate = 15;

	
	// Update is called once per frame
	void FixedUpdate () {
        TransmitPosition();
        lerpPos();
	}
    void lerpPos()
    {
        if (!isLocalPlayer)
        {
            myRigidbody.position = Vector3.Lerp(myRigidbody.position, syncPos, Time.deltaTime * lerpRate);
        }
    }
    [Command]
    void CmdProvidePositionToServer(Vector3 pos)
    {
        
        syncPos = pos;
    }
    [ClientCallback]
    void TransmitPosition()
    {
        if(isLocalPlayer)
        CmdProvidePositionToServer(myRigidbody.position);
    }
}
