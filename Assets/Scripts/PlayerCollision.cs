using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public string tagName = "Obstacle";
    public Move movement;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag(tagName))
        {
            Debug.Log("We hint obstacle");
            movement.enabled = false;
        }
    }
}
