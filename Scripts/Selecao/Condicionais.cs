using System.Runtime.CompilerServices;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    public int n1 = 10;
    public int n2 = 9;

    private void Update()
    {
        if (n1 > n2)
        {
            Debug.Log(n1 + " � maior que " + n2);
        }
        else if (n2 < n1) 
        {
                Debug.Log(n1 + " � menor que  " + n2);
        }
        else 
        {
                Debug.Log(n1 + " � igual a   " + n2);
        }      
    }
}
