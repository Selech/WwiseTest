using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TestEvent(){
		AkSoundEngine.PostEvent("Play_Bell",this.gameObject);
	}
}
