using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    bool happybool = true;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonClick(bool happybool)
    {
        if (!happybool)
        {
            Debug.Log("YAY false");

        }


    }

    public void Credits()
    {
        Debug.Log("Game Made By Team Production Class Team Awesome!!!");
    }
}


