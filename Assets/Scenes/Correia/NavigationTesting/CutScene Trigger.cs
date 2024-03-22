using UnityEngine;
using UnityEngine.Playables;

public class PlayerTimelineController : MonoBehaviour
{
    [Header("Optional Reference")]
    [SerializeField] CutSceneManager cutSceneManager;

    [SerializeField] private Vector3 startingPosition;
    private bool isMovingToStartPosition = false;
    private Transform shipTransform;
    [SerializeField] private Transform moveTarget;
    private Transform camTransform;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float rotationSpeed = 90f;
    [SerializeField] private float stoppingDistance = 0.3f;

    void Update()
    {
        if (isMovingToStartPosition)
        {
            // Move the ship
            Vector3 shipPosition = shipTransform.position;
            shipPosition.y = moveTarget.position.y;
            float distance = Vector3.Distance(shipPosition, moveTarget.position);
            if (distance > stoppingDistance)
            {
                Vector3 direction = (moveTarget.position - shipTransform.position).normalized;
                direction.y = 0;
                Vector3 newPosition = shipTransform.position + direction * moveSpeed * Time.deltaTime;
                shipTransform.position = newPosition;

                // Rotate the ship towards the target
                //Quaternion targetRotation = Quaternion.LookRotation(direction);
                //shipTransform.rotation = Quaternion.RotateTowards(shipTransform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
            else
            {
                isMovingToStartPosition = false;
                cutSceneManager.beginCutScene();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        BoatMovement boatMovement = other.GetComponent<BoatMovement>();
        if (boatMovement != null)
        {
            boatMovement.AllowPlayerControl(false);
            moveSpeed = boatMovement.MaxVelocity;
            shipTransform = other.gameObject.transform;
            isMovingToStartPosition = true;
        }
    }
}
