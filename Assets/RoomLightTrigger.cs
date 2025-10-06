using TMPro;
using UnityEngine;

public class RoomLightTrigger : MonoBehaviour
{
    public Light directionalLight;
    public TextMeshPro TextMeshPro;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // or your VR camera/player rig tag
        {
            directionalLight.enabled = true;
            TextMeshPro.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            directionalLight.enabled = false;
            TextMeshPro.enabled = false;
        }
    }
}
