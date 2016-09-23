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

	public void TestEvent2(){
		AkSoundEngine.PostEvent("Play_Snap",this.gameObject);
	}

	public void TestEvent3(){
		AkSoundEngine.PostEvent("Play_Ambience1",this.gameObject);
	}
}
