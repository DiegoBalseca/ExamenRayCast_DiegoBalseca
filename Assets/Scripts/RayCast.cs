using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript : MonoBehaviour
{
    InputAction _clickAction;
    InputAction _positionAction;

    Vector2 _mousePosition;

    void Awake()
    {
        _clickAction = InputSystem.actions["Attack"];

        _positionAction = InputSystem.actions["Look"];
    }

 void Update()
    {
        _mousePosition = _positionAction.ReadValue<Vector2>();

        if(_clickAction.WasPerformedThisFrame())
        {
            ShootRaycast();     
        }
    }

    private void ShootRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);
        RaycastHit hit; 
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.layer == 5)
            {
                Debug.Log("Detecta caja");

            }
            
        }
    }

}






