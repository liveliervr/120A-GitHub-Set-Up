using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter7Seconds : MonoBehaviour
{

    private float destroyTime = 6.0f;

    // Start is called before the first frame update.
    void Start()
    {
        // Start a coroutine that will destroy the GameObject after 7 seconds.
        StartCoroutine(WaitAndDestroy());
    }

    private IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
