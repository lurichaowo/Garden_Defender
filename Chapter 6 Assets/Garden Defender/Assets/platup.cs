using UnityEngine;
using System.Collections;

public class platup : MonoBehaviour {
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
                transform.position += Vector3.up * Time.deltaTime;
        }
    }
}
