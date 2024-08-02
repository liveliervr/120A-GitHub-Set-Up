using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject Respawn;

  
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ground")
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Respawn.SetActive(true);
        }

    }
}
