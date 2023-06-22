using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    
    public Transform borderRight;
    public Transform borderLeft;
    
    public float Intrerval;
    public float Timer;

    void Spawn()
    {
        float randomX = Random.Range(borderLeft.position.x, borderRight.position.x);
        
        Vector2 newPosition = transform.position;
        newPosition.x = randomX;
        
        Instantiate(prefab, newPosition, Quaternion.identuty);
        Timer = Interval;
    }
    
    void Update()
    {
       Timer -= Time.deltaTime;
       
       if(Timer <=0)
       {
            Spawn();
       }
    }
}
