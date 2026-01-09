using System;
using UnityEngine;
using UnityEngine.Events;
public class PlayerEnterScript : MonoBehaviour
{
    
    public UnityEvent Event;
    public UnityEvent EventTrigger;
    void OnCollisionEnter2D(Collision2D collision) 
    { 
        if (collision.gameObject.CompareTag("Player") && Event != null) 
        { 
            Event.Invoke();
        } 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Event != null) 
        { 
            EventTrigger.Invoke();
        } 
    }
}
