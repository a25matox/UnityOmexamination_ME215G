using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    
    [SerializeField]
    private Vector3 playerPosition;
    
    public void movetoplayer()
    {
        transform.localPosition = playerPosition;
        transform.parent = player;
    }
}
