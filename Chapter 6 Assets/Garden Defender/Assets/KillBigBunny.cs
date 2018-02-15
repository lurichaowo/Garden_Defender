using UnityEngine;
using System.Collections;

public class KillBigBunny : MonoBehaviour
{
    private int count = 0;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bigbunny")
        {
            count++;
            if (count == 10)
            {
                Destroy(col.gameObject);
            }
        }
    }

    void Update()
    {
        if (count >= 10)
        {
            count = 0;
        }
    }
}
