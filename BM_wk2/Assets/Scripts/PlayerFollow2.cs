using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow2 : MonoBehaviour
{
    public Transform player;
    public Vector3 offset2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {

    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset2;
    }
}
