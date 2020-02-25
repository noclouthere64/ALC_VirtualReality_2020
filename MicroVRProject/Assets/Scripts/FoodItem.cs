﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public MeshRenderer mr;
    public float cookRate;

    private bool isCooking;

    // Update is called once per frame
    void Update()
    {
        if(isCooking)
            mr.material.color = Color.Lerp(mr.material.color, Color.black, cookRate * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("CookSurface"))
            isCooking = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("CookSurface"))
            isCooking = false;
    }
}