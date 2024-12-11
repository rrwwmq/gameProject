using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OtherObject"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
