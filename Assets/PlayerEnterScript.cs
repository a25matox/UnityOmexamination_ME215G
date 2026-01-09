using UnityEngine;
using UnityEngine.Events;
public class PlayerEnterScript : MonoBehaviour
{
    
    public UnityEvent Event;
    void OnCollisionEnter2D(Collision2D collision) 
    { 
        if (collision.gameObject.CompareTag("Player")) 
        { 
            Event.Invoke();
        } 
    } 
}
