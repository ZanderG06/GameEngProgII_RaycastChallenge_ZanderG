using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseRaycast : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI raycastDisplay;

    private void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (Physics.Raycast(ray, out RaycastHit raycastHit) && raycastHit.transform != null) CheckClickedObject(raycastHit.transform.gameObject);
        }
    }

    private void CheckClickedObject(GameObject gameObject)
    {
        if (gameObject.name == "Pickup") Destroy(gameObject);
        else if (gameObject.name == "ColorChange") gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
        else gameObject.GetComponent<Animator>().enabled = !gameObject.GetComponent<Animator>().enabled;
    }
}