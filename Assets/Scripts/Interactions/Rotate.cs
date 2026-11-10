using UnityEngine;

public class Rotate : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(50f * Time.deltaTime * Vector3.forward);
    }
}