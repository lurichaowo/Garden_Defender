using UnityEngine;
using System.Collections;

public class ScareMove : MonoBehaviour {
    // Use this for initialization
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.forward * Time.deltaTime/5;
        gameObject.transform.Rotate(0, 1, 0);
        transform.position -= Vector3.forward * Time.deltaTime / 4;
    }
}
