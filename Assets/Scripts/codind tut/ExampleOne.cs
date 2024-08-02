using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleOne : MonoBehaviour
{
    int MyInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        MyInt = MultiplyByTwo(MyInt);
        Debug.Log(MyInt);
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
