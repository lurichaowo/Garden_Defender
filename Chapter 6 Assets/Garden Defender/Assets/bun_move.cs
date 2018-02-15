using UnityEngine;
using System.Collections;

public class bun_move : MonoBehaviour
{
	void Update()
    {
        transform.position += transform.forward * (Time.deltaTime/4);
        gameObject.transform.Rotate(0, 1/3, 0);
    }

    void OncollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("plant"))
        {
            Destroy(col.gameObject);
        }
    }
}
