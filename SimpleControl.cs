using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class  SimpleControl: MonoBehaviour{

    Animator miAnimator;

    bool salto;

    // Start is called before the first frame update
    void Start()
    {
        miAnimator = GetComponent<Animator>();
    }

    private void OnFire (InputValue movementValue)
    {

        Debug.Log("Estoy en la consola");
       
    }
}
