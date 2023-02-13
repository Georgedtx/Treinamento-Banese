using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeticaoFor : MonoBehaviour
{
    public int repeticoes = 10;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= repeticoes; i++)
        {
            Debug.Log(i);
        }
    }
}
