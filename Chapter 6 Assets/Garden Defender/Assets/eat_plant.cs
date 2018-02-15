using UnityEngine;
using System.Collections;

public class eat_plant : MonoBehaviour {
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("plant"))
        {
            Destroy(col.gameObject);
        }
    }
}
