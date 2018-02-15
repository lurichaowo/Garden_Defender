using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class counter : MonoBehaviour {
    private int bcounter;
    public Text btext;
    // Use this for initialization
    void Start () {
        bcounter = 0;
        SetCountText();
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] bunny = GameObject.FindGameObjectsWithTag("bunny");
        bcounter = bunny.Length;
        SetCountText();
    }

    void SetCountText()
    {
        if (bcounter == 0)
        {
            btext.text = "You Win!";
        }
        else
        {
            btext.text = "Bunny: " + bcounter.ToString();
        }
    }
}
