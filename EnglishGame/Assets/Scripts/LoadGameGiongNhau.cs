using UnityEngine;
using System.Collections;

public class LoadGameGiongNhau : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnClick()
	{
		Application.LoadLevel ("Ten Scene");// them ten cua scene muon load sang
		print ("load duoc roi nhe");
	}
}
