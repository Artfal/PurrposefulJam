﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float minHeight, maxHeight, minScroll, maxScroll;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(player.transform.position.x, Mathf.Clamp(player.transform.position.y, minHeight, maxHeight), transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, minScroll, maxScroll), Mathf.Clamp(player.transform.position.y, minHeight, maxHeight), transform.position.z);
    }
}
