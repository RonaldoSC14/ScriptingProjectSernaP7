using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LinearInterpolation : MonoBehaviour
{
    // In this case, result = 8
    float result = Mathf.Lerp(6f, 10f, 0.5f);

    Vector3 from = Vector3.zero;
    Vector3 to = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
         
    }

    private void LateUpdate()
    {
        
    }


}
