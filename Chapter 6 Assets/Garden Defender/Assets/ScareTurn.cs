using UnityEngine;
using System.Collections;

public class ScareTurn : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float speed = 0.1F;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("wall"))
        {
            transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);
        }
    }
}
