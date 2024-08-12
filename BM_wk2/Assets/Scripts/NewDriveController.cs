using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDriveController : MonoBehaviour
{

    public float speed = 5;
    public float horizontalInput;
    public float rotationSpeed;

    // https://www.youtube.com/watch?v=QQs9MWLU_tU&ab_channel=b3agz 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
