using UnityEngine;

public class CameraController : MonoBehaviour
{
    //follow player
    [SerializeField]private Transform player;
    [SerializeField]private float aheadDistance;
    [SerializeField]private float cameraSpeed;
    private float lookAhead;

    private void Update() {
    transform.position = new Vector3(player.position.x + lookAhead, transform.position.y, transform.position.z);
    lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.transform.localScale.x), Time.deltaTime * cameraSpeed);
    }

}
