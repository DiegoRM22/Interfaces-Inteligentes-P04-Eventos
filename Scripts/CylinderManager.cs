using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderManager : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void OnCubeCollision();
    public event OnCubeCollision OnCubeCollisionEvent;
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Cube") {
            if (OnCubeCollisionEvent != null) {
                OnCubeCollisionEvent();
            } else {
                Debug.Log("No subscribers");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
