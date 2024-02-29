using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    public GameObject other;
    public GameObject other2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            Destroy(other);
        }

        if (Input.GetKeyUp(KeyCode.P))
        {  
            Destroy(other2);
        }
    }
}
