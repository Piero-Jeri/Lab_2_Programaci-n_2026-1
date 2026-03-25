using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private int ammo = 10;

    void Start()
    {
        
    }
    public void Shoot(Player target)
    {
        if (target == null || ammo <= 0)
        {
            Debug.Log("No Bullets or No Target");
            return;
        }

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
