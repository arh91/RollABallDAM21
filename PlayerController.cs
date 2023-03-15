using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float speed = 10; //Cambio la velocidad a 10 para que el Object se mueva más rápido
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
    
    
    //Método para manejar las interacciones del Player con otros objetos, y cómo el Player va a responder a dichas interacciones.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy")) //Si colisiono con un objeto de tag "Destroy", éste se destruye.
        {
            other.gameObject.SetActive(false);
        }
        
        if (other.gameObject.CompareTag("Teleport")) //Si colisiono con un objeto de tag "Teleport", el Player se teletransporta a la posición (.4, 0,5, .7).
        {
            gameObject.transform.position = new Vector3(-4f, 0.5f, -7f);
        }

		if (other.gameObject.CompareTag("Slow")) //Si colisiono con un objeto de tag "Slow", la velocidad del Player se reduce a 3.
        {
            speed = 3;
        }

		if (other.gameObject.CompareTag("Fast")) //Si colisiono con un objeto de tag "Fast", la velocidad del Player de nuevo volverá a ser 10.
        {
            speed = 8;
        }
    }
}
