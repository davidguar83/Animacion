using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class SimpleControl : MonoBehaviour
{
    
    Animator miAnimator;

   

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

                Debug.Log("salto Iniciada");
                Salto();
                break;

            case InputActionPhase.Canceled:
                Debug.Log("salto Cancelada");
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

    public void OnMove(InputAction.CallbackContext context)
    {
        
        switch (context.phase)
        {
            case InputActionPhase.Performed:
               
                if (context.interaction is SlowTapInteraction)
                {
                  //strar run 
                    Run();
                    
                }
                else
                {
                   // stop run
                    miAnimator.SetBool("run", false);
                }
                break;

            case InputActionPhase.Started:
               // start run
                Run();
                break;

            case InputActionPhase.Canceled:
                Debug.Log("Phase Cancelelada");
                // stop run
                miAnimator.SetBool("run", false);
                break;
        }
    }



  


    private void Run()
    {

        miAnimator.SetBool("run", true);

    }



}

