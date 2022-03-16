using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject VehicleObj;
    private Vector3 offset;
    // Start is called before the first frame update
   
    void Start()
    {
        // set offset variable with camera and vehicle position
        offset = this.transform.position - VehicleObj.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera behind the player by adding to the player's position
        this.transform.position = VehicleObj.transform.position + offset;
    }
}
