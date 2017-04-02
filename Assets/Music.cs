using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	static Music instance=null;
	
	void Awake(){
		if(instance!=null){
			Destroy(gameObject);
			print("Music Player self destructing");
		}
		else{
			instance=this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
