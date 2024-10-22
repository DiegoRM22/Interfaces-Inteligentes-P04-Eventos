using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSpider : MonoBehaviour
{
    // Start is called before the first frame update
    public CubeCollision cubeCollision;
    public GameObject teleportTarget;
    private Rigidbody rb;
    void Start()
    {
        cubeCollision.OnApproximation += Teleport;
        rb = GetComponent<Rigidbody>();
    }

    void Teleport() {
        rb.MovePosition(teleportTarget.transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
