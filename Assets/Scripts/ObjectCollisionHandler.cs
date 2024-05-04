using UnityEngine;

public class ObjectCollisionHandler : MonoBehaviour
{
    public GameObject[] spiritPartsObjects;
    private int currentPartIndex = 0;
    private bool collisionDetected = false;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific tag or layer if needed
        if (collision.gameObject.CompareTag("OtherObjectTag"))
        {
            collisionDetected = true;
        }
    }

    private void Update()
    {
        if (collisionDetected && currentPartIndex < spiritPartsObjects.Length)
        {
            spiritPartsObjects[currentPartIndex].SetActive(true);
            currentPartIndex++;
            collisionDetected = false; // Reset collision detection until next collision
        }
    }
}
