using UnityEngine;
using System.Collections;

public class AddChildButton : MonoBehaviour {
	GameObject uiButton;
	GameObject uiParent;
	// Use this for initialization
	void Start () {
		uiButton = (GameObject)Resources.Load ("Button");
		uiParent = GameObject.Find ("Grid");
		Parent (uiParent,uiButton);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
	void Parent( GameObject parentOb, GameObject childOb )
	{
		childOb.transform.parent = parentOb.transform;
	}

}
