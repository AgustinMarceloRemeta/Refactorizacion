using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    int force, agility;
    
    private Start()
    {
        force = 100;
        agility = 50;
    } 

    private void SpecialAttack()
    {
       bool isForceSpecial = (force * 2) / 5 > -1
       bool isAgility = (agility / 2 > 20)

        if (isForceSpecial && isAgility) Debug.Log("Special Attack");
      
    }
}
