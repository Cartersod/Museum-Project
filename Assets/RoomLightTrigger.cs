using UnityEngine;

public class RoomLightTrigger : MonoBehaviour
{
    public Light directionalLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // or your VR camera/player rig tag
        {
            directionalLight.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            directionalLight.enabled = false;
        }
    }
}
