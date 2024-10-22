using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderOrentation : MonoBehaviour
{
    public CubeCollision cubeCollision;
    public GameObject target;
    void Start()
    {
        cubeCollision.OnApproximation += ChangeOrientation;
    }

    void ChangeOrientation() {
        transform.LookAt(target.transform);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
