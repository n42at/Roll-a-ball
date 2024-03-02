using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset=transform.position - player.transform.position; //set offset = equal camera transform position - player object transform position
    }

    // Update is called once per frame
    void LateUpdate() // lateupdate runs every frame after all update are done
    {
        transform.position=player.transform.position+offset; 
        //matching position and not rotation 
    }
}
