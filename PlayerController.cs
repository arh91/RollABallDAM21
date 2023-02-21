using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float speed = 8; //Cambio la velocidad a 8 para que el Object se mueva más rápido
    private Rigidbody rb; //Rigidbody es una clase que permite que el GameObject esté sometido a las leyes de la física (gravedad, rozamiento, colisión con otros objetos...).
    private float movementX;
    private float movementY;
    
    
    // Este método inicializa el Object. Sólo se llama si el GameObject está previamente activado.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Establecemos que el Object se moverá en el eje X y en el eje Y.
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    
    /*Método que será llamado en cada frame. Todas las actualizaciones físicas (paso del motor físico)
    se llevarán a cabo tras la ejecución de este método*/
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
}