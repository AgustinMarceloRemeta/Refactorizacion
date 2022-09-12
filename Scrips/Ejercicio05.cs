using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    string acción;
    int habilidad;

    void Start()
    {
        acción = "Attack"
        habilidad = 1
    }

    void EjecutarAcción()
    {
     if (acción == "Heal" && habilidad == 1)
                  Debug.Log("Me curé");
         
     else  if (acción == "Attack" && habilidad == 2)
                  Debug.Log("Hago daño");
           
     else if (acción == "Special Attack" && habilidad == 3)
                  Debug.Log("Empiezo a girar como trompo");
    }
}

