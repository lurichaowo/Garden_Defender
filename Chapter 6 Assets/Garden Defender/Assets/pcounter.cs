using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pcounter : MonoBehaviour {
    private int pcounters;
    public Text ptext;
    // Use this for initialization
    void Start()
    {
        GameObject[] bunny = GameObject.FindGameObjectsWithTag("plant");
        pcounters = bunny.Length;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] bunny = GameObject.FindGameObjectsWithTag("plant");
        pcounters = bunny.Length - 1;
        SetCountText();
    }

    void SetCountText()
    {
        if (pcounters <= 0)
        {
            ptext.text = "You Lose!";
        }
        else
        {
            ptext.text = "Plants: " + pcounters.ToString();
        }
    }
}
