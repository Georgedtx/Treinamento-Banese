using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicionalT : MonoBehaviour
{
    public int n1;
    public int n2;

    // Update is called once per frame
    void Update()
    {
        if (n1 > n2 || n1 < n2)
        {
            Debug.Log(n1 + " é diferente " + n2);
        }else 
        {
            Debug.Log(n1 + " é igual " + n2);
        }
    }
}
