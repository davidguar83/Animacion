using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class SimpleControl : MonoBehaviour
{
    
    Animator miAnimator;

    bool salto;

    // Start is called before the first frame update
    void Start()
    {
    miAnimator = GetComponent<Animator>();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:

                if(context.interaction is SlowTapInteraction)
                {

                    Debug.Log("tecla pulsada continuamente");
                    Salto();

                }
                else
                {

                    Debug.Log("Salto efectuado");
                    miAnimator.SetBool("Salto", false);
                }
                break;

            case InputActionPhase.Started:

                Debug.Log("Phase Iniciada");
                Salto();
                break;

            case InputActionPhase.Canceled:
                Debug.Log("Phase Cancelada");
                miAnimator.SetBool("salto", false);
                break;

      //  Debug.Log("Estoy en OnFire");
       // miAnimator.SetBool("salto", true);


               

        }
    }


    private void Salto()
    {

        miAnimator.SetBool("salto", true);

    }



}

