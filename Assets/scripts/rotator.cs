using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    
    // Update is called once per frame
    // translate and rotate for transform .. translate: moves by transform
    // rotates by its transform .. has 2 intial prameters
    // using vector3 and  the other using 3 float value (x,y,z)
    
    void Update()
    {
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
    }
    /*
    Delta time, or also referred to as elapsed time is usually 
    a value that is calculated for us within modern game engines
    such as Unity or Unreal. Delta time describes the time 
    difference between the previous frame that was drawn and 
    the current frame
    */


}
