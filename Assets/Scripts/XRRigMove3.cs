using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRRigMove3 : MonoBehaviour
{
    public GameObject XRRig1;
    void Start()
    {
        
    }
    public void changeCam()
    {
        XRRig1.transform.position = new Vector3(39, 1, 4);
    }
}
