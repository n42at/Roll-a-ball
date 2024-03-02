using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingwalls : MonoBehaviour
{
    public GameObject[] waypoints;
    int current =0;
    float rotspeed;
    public float speed;
    float wpradius =1;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    { if (Vector3.Distance(waypoints[current].transform.position, transform.position) < wpradius)
   {
    current++;
    if(current>= waypoints.Length)
    {
     current=0;   
    }
   }
    transform.position=Vector3.MoveTowards(transform.position,waypoints[current].transform.position,Time.deltaTime *speed);
}
}
