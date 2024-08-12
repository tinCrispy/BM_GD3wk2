using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset, offset2;
    bool isMainCamera = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void LateUpdate()
    { 

            if (isMainCamera == false)
                transform.position = player.position + offset2;
            else
                transform.position = player.position + offset;


        

        if (Input.GetKeyDown(KeyCode.V))

        {
            if (isMainCamera == true)

            {
                isMainCamera = false;
            }

            else isMainCamera = true;

        }


        
    }
}
