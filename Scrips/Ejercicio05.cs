using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    [Range(1, 20)]
    public int criticalChance;
    public int MaxDie;

    public void CriticalDamage()
    {
        int die = Random.Range(0, criticalChance);

        if (die < MaxDie)
        {
            Debug.Log("Normal Attack")
            return
        }
        Debug.Log("Critical Hit");
    }
}
