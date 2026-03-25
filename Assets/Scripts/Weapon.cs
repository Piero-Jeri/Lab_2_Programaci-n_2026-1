using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int damage;
    private int ammo = 10;

    void Start()
    {
        
    }
    public void Shoot(Player target)
    {
        if (target == null || ammo <= 0)
            return;

        //->if
        if (ammo <= 0)
        {
            Debug.Log("No Bullets");
        }

        //-> else
        else
        {
            target.TakeDamage(damage);

            Debug.Log("Shoot!");

            ammo--;
        }
    }

}
