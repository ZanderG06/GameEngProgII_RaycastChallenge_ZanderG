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

            if (Physics.Raycast(ray, out RaycastHit raycastHit) && raycastHit.transform != null) raycastDisplay.text = $"Hit: {raycastHit.transform.name}";
        }
    }
}