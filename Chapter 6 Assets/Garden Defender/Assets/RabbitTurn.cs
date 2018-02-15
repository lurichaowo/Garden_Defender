using UnityEngine;
using System.Collections;

public class RabbitTurn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other) {
            other.gameObject.transform.Rotate(Vector3.right * Time.deltaTime);
        }
    }
