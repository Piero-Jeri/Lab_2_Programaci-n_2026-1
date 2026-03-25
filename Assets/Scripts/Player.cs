using UnityEngine;

public class Player : MonoBehaviour
{
    private Health health = new();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        //-> Manera para llamar el TakeDamage entre clases
        health.TakeDamage(damage);
    }
}
