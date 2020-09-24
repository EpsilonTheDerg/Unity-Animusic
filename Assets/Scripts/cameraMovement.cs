﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    private float lastmousex;
    private float lastmousey;
    private float mousemovex;
    private float mousemovey;

    // Start is called before the first frame update
    void Start(){
        lastmousex = Input.mousePosition.x;
        lastmousey = Input.mousePosition.y;
    }

    // Update is called once per frame
    void Update(){
        mousemovex = (lastmousex - Input.mousePosition.x) / -4;
        mousemovey = (lastmousey - Input.mousePosition.y) / 4;
        lastmousex = Input.mousePosition.x;
        lastmousey = Input.mousePosition.y;
        if (Application.isFocused) {
            if (Input.GetMouseButton(2)) {
                if (Input.GetKey("left shift")){
                    transform.position += transform.up * (mousemovey / 16);
                    transform.position += transform.right * (mousemovex / -16);
                } else {
                    transform.Rotate(0, mousemovex, 0, Space.World);
                    transform.Rotate(mousemovey, 0, 0);
                    print(mousemovex);
                }                
            }
            transform.position += transform.forward * (Input.mouseScrollDelta.y * 0.1f);
        }
    }
}
