using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class togglecam : MonoBehaviour {
 
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;

    public void switchcam(int x) {

        deactivateall();
        if (x == 1)
        {
            cam1.enabled = true;
        }
        else if (x == 2)
        {
            cam2.enabled = true;
        }
        else if (x == 3)
        {
            cam3.enabled = true;
        }
       
        else if (x == 4)
        {
            cam4.enabled = true;
        }

        else if (x == 5)
        {
            cam5.enabled = true;
        }
       
        else {
            cam6.enabled = true;
        }
    }
 
    public void deactivateall() {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
    }
}