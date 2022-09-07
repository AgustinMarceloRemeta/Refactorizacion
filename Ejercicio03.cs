using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
   public int resistance, resistanceMin, life, restDamage;

    void GetDamage(int damage)
    {
     
        if (resistance > resistanceMin) damage -= restDamage;

        life -= damage;
        
    }
}
