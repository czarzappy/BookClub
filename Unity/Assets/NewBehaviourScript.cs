using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	bool refresh = true;
	HostData [] data;
	// Use this for initialization
	void Start () {
		MasterServer.RequestHostList ("ProjectDragonite");
	//	Debug.Log(MasterServer.PollHostList().Length);
	//	Debug.Log ("hello world");
	}
	
	// Update is called once per frame
	void Update () {

		if (refresh)
			data =	MasterServer.PollHostList ();
		if (data.Length > 0) {
			refresh = false;
			try{
				Network.Connect(data[0]);
			}
			catch(UnityException e){
				Debug.Log("OH NO");
			}
			Debug.Log(data[0].passwordProtected);
		}

		Debug.Log (data.Length);
	}
}
