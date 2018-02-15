using UnityEngine;
using System.Collections;

public class KillBunny : MonoBehaviour {
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bunny" || col.gameObject.tag == "plant")
        {
            Destroy(col.gameObject);
        }
    }
}
