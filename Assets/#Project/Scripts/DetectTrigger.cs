using UnityEngine;

public class DetectTrigger : MonoBehaviour
{

    [SerializeField] string tagName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagName))
        {
            Debug.Log($"------------------Hi {other.name}");
        }
    }

}
