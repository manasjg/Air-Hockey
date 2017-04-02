using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;
 
public class UpdateScore : NetworkBehaviour {
    
    public Text text;
	public Puck puck;
	private LevelManager lm;
    [SyncVar]
    private Vector3 pos;
    [SyncVar]
	int score=0;
	
	// Use this for initialization
	void Start () {
	text.text=score.ToString();
        puck = GameObject.FindObjectOfType<Puck>();
	
	lm=GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnTriggerEnter2D(Collider2D coll){
       
            
        if (coll.gameObject.tag == "Puck")
        {
            score++;
            coll.gameObject.transform.position = new Vector3(0, 0, 0);
            coll.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
       
		if(score==8 && text.tag=="Red"){
			lm.LoadLevel("WinRed");
		}
		else if(score==8 && text.tag=="Blue"){
			lm.LoadLevel("WinBlue");
		}
		else{ 
    
		text.text=score.ToString();
       
		}
	}
}
