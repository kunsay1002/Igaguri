﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    
    void Start()
    {
        
    }

    
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri =
                Instantiate(igaguriPrefab) as GameObject;
            igaguri.GetComponent<IgaguriController>().Shoot(
                new Vector3(0, 200, 2000));
        }
    }
}
