using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeticaoWhile : MonoBehaviour
{
    public int num = 10;

    // Update is called once per frame
    void Start()
    {
        while (num >= 0)
        {
            Debug.Log(num);
            num--;
        }
    }
}
