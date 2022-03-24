using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 6,- 2);
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position=player.transform.position+offset;
       
    }
}
