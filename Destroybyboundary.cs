using UnityEngine;
using System.Collections;

public class Destroybyboundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
