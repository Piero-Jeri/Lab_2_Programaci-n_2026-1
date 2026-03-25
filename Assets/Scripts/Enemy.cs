using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int vida = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            TakeDamage(vida);
        }
    }

    public void TakeDamage(int cantidad)
    {
        if (vida <= 0)
        {
            Debug.Log("Dejalo, ya está muerto! :'c");
            return;
        }

        vida -= 10;
        Debug.Log("Enemigo recibió daño. Vida actual: " + vida);

    }
}
