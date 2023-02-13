using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionalternaria : MonoBehaviour
{
    public int n1;
    public int n2;


    // Update is called once per frame
    void Update()
    {
        Debug.Log((n1 != n2)? (n1 +"é diferente de " +n2):(n1+"é igual "+n2));    
    }
}
