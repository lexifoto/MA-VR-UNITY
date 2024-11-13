using UnityEngine;
using UnityEngine.AI;

public class RaycastNavMeshMovement : MonoBehaviour
{
    public Camera playerCamera;       // Reference to the camera used to cast the ray
    public NavMeshAgent agent;        // Reference to the NavMeshAgent component
    public float raycastRange = 100f; // Maximum range of the ray
    public Color raycolor = Color.blue;

    void Update()
    {
        // Check for Space key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CastRay();
        }
    }

    void CastRay()
    {
        // Create a ray from the camera's position pointing forward
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        // Check if the ray hits something within the specified range
        if (Physics.Raycast(ray, out hit, raycastRange))
        {
            // Check if the hit point is on a valid NavMesh surface
            NavMeshHit navMeshHit;
            if (NavMesh.SamplePosition(hit.point, out navMeshHit, 1.0f, NavMesh.AllAreas))
            {
                // Set the NavMeshAgent's destination to the point on the NavMesh
                agent.SetDestination(navMeshHit.position);
                Debug.Log("Moving agent to: " + navMeshHit.position);
            }
            else
            {
                Debug.Log("Hit point is not on the NavMesh.");
            }
        }
        else
        {
            Debug.Log("No hit detected.");
        }

        // Draw the ray in the Scene view for debugging purposes
        Debug.DrawRay(ray.origin, ray.direction * raycastRange, Color.red, 1.0f);
    }
}
