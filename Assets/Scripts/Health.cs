using System;
using UnityEngine;


[Serializable]
public class Health
{

    private int value = 30;

    public void TakeDamage(int damage)
    {
        value -= damage;
        if (value < 0)
        {
            value = 0;
        }

        Debug.Log("Daño: " + damage + " | Vida Restante: " + value);
    }

    public int GetLife()
    {
        Debug.Log("Current Life: " + value);
        return value;
    }
}
