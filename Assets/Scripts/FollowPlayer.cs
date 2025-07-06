using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -12);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // LateUpdate is called after update method
    void LateUpdate()
    {
        // offset the camera behinf the player by adding it's initial position to player's position
        transform.position = player.transform.position + offset;

        //new Vector3(0, 8, -12); -- the initial camera position above vehicle
    }
}
