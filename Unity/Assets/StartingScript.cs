using UnityEngine;
using System.Collections;

public class StartingScript : MonoBehaviour {

	public GameObject buyPanel;
	public GameObject settingsPanel;

	// Use this for initialization
	void Start () {
		buyPanel.SetActive (false);
		settingsPanel.SetActive (false);
	}

}
