using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereResponse : MonoBehaviour
{
    public CylinderManager cylinderManager; // Referencia al CylinderManager
    private MoveTowardsSphere2 moveTowardsSphere2; // Referencia al script MoveTowardsSphere2
    void Start()
    {
        // Suscripción al evento estático usando la instancia de CylinderManager
        cylinderManager.OnCubeCollisionEvent += myResponse;
    }

    void myResponse() 
    {

        // Obtiene el componente MoveTowardsSphere2
        moveTowardsSphere2 = GetComponent<MoveTowardsSphere2>();
        moveTowardsSphere2.enabled = !moveTowardsSphere2.enabled;
    }

    private void OnDestroy()
    {
        // Desuscripción del evento para evitar memory leaks
        cylinderManager.OnCubeCollisionEvent -= myResponse;
    }
}
