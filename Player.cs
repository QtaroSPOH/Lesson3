using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audiosource;
    public AudioClip damagedSound;
    private int health = 10;

    public void CollectCoins()
    {
        coins++;

// audiosource.PlayOneShot(collectSound);

        print("Собранные монетки:" + coins);
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:" + health);
    }

    

}
