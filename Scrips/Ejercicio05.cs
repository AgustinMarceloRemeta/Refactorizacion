using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    string acci�n;
    int habilidad;

    void Start()
    {
        acci�n = "Attack"
        habilidad = 1
    }

    void EjecutarAcci�n()
    {
     if (acci�n == "Heal" && habilidad == 1)
                  Debug.Log("Me cur�");
         
     else  if (acci�n == "Attack" && habilidad == 2)
                  Debug.Log("Hago da�o");
           
     else if (acci�n == "Special Attack" && habilidad == 3)
                  Debug.Log("Empiezo a girar como trompo");
    }
}

