using System.Collections;
using UnityEngine;

public class RecenterOnLoad : MonoBehaviour
{
    IEnumerator Start()
    {
        // Wait a few frames so tracking is ready after the scene loads
        for (int i = 0; i < 5; i++) yield return null;

        OVRManager.display.RecenterPose();
    }
}