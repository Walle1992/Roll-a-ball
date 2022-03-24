using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollects : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //rotate all pickUps
        transform.Rotate(new Vector3(10f, 20f, 30f) * Time.deltaTime);
    }

}
