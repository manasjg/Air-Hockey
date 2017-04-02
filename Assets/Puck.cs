using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Puck : NetworkBehaviour {
	Vector2 vel;
	
	Vector2 touch1Pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		touch1Pos=Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
	}
		
	void OnCollisionEnter2D(Collision2D coll){
		Debug.Log("Collision with" + coll.gameObject);
		if(coll.gameObject.tag=="Blue"){
            GetComponent<Rigidbody2D>().velocity = new Vector2(1.5f * Input.GetTouch(0).deltaPosition.x,1.5f*Input.GetTouch(0).deltaPosition.y);
            vel = GetComponent<Rigidbody2D>().velocity;
			/*if(touch2Pos.x>0){
				if(Input.GetTouch(1).phase==TouchPhase.Stationary){
					GetComponent<Rigidbody2D>().velocity=new Vector2(-(vel.x-2),vel.y-2);
					vel=GetComponent<Rigidbody2D>().velocity;
				}else{
				GetComponent<Rigidbody2D>().velocity=new Vector2(1.5f*(Input.GetTouch(1).deltaPosition.x),1.5f*(Input.GetTouch(1).deltaPosition.y));
				vel=GetComponent<Rigidbody2D>().velocity;}
			}else if(touch1Pos.x>0){
				if(Input.GetTouch(0).phase==TouchPhase.Stationary){
					GetComponent<Rigidbody2D>().velocity=new Vector2(-(vel.x-2),vel.y-2);
					vel=GetComponent<Rigidbody2D>().velocity;
				}else{
					GetComponent<Rigidbody2D>().velocity=new Vector2(1.5f*(Input.GetTouch(0).deltaPosition.x),1.5f*(Input.GetTouch(0).deltaPosition.y));
					vel=GetComponent<Rigidbody2D>().velocity;}
			}*/
			
			/*if(coll.contacts[0].point.y<0){
			rigidbody2D.velocity=new Vector2(-5f,-5f);
			}else 	if(coll.contacts[0].point.y>0){
				rigidbody2D.velocity=new Vector2(-5f,5f);
			}else {
				rigidbody2D.velocity=new Vector2(5f,5f);
			}*/
	}
		/*if(coll.gameObject.tag=="Red"){
			if(touch2Pos.x<0){
				if(Input.GetTouch(1).phase==TouchPhase.Stationary){
					GetComponent<Rigidbody2D>().velocity=new Vector2(-(vel.x+2),vel.y-2);
					vel=GetComponent<Rigidbody2D>().velocity;
				}else{
					GetComponent<Rigidbody2D>().velocity=new Vector2(1.5f*(Input.GetTouch(1).deltaPosition.x),1.5f*(Input.GetTouch(1).deltaPosition.y));
					vel=GetComponent<Rigidbody2D>().velocity;}
			}else if(touch1Pos.x<0){
				if(Input.GetTouch(0).phase==TouchPhase.Stationary){
					GetComponent<Rigidbody2D>().velocity=new Vector2(-(vel.x+2),vel.y-2);
					vel=GetComponent<Rigidbody2D>().velocity;
				}else{
					GetComponent<Rigidbody2D>().velocity=new Vector2(1.5f*(Input.GetTouch(0).deltaPosition.x),1.5f*(Input.GetTouch(0).deltaPosition.y));
					vel=GetComponent<Rigidbody2D>().velocity;}
			}*/
			/*if(coll.contacts[0].point.y<0){
				rigidbody2D.velocity=new Vector2(5f,-5f);
			}else 	if(coll.contacts[0].point.y>0){
				rigidbody2D.velocity=new Vector2(5f,5f);
			}else {
				rigidbody2D.velocity=new Vector2(-5f,5f);
			}*/
			//}
		if (coll.gameObject.tag=="Wall"){
			GetComponent<Rigidbody2D>().velocity=new Vector2(vel.x,-vel.y);
			vel=GetComponent<Rigidbody2D>().velocity;
			}	
		if (coll.gameObject.tag=="Wall2"){
			GetComponent<Rigidbody2D>().velocity=new Vector2(-vel.x,vel.y);
			vel=GetComponent<Rigidbody2D>().velocity;
		}	
		
}
}