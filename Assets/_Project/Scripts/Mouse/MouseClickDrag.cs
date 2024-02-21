using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickDrag : MonoBehaviour
{

    private GameObject draggableObject;
    private float dMaxUp, dMaxDown, dMaxRight, dMaxLeft, mouseX, mouseY;
    [SerializeField] private Camera camera2D;
    private Vector2 mousePosition, mouseClickPosition;

    void Update()
    {
        mousePosition = camera2D.ScreenToWorldPoint(Input.mousePosition);
        if(!Mode.mode3D)
        {
          GetDraggableObject();

          if(draggableObject != null)
          {
            MoveDraggableObject();
          }
        }
    }

    private void GetDraggableObject()
    {
      if(Input.GetMouseButtonDown(0))
      {
        Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

        if(targetObject != null)
        {
          draggableObject = targetObject.transform.gameObject;
          mouseClickPosition = mousePosition;
          Draggable dragScript = draggableObject.GetComponent<Draggable>();
          dMaxUp = dragScript.maxUp;
          dMaxDown = dragScript.maxDown;
          dMaxRight = dragScript.maxRight;
          dMaxLeft = dragScript.maxLeft;
        }
      }
      if(Input.GetMouseButtonUp(0))
      {
        if(draggableObject != null)
        {
          draggableObject = null;
        }
      }
    }

    private void MoveDraggableObject()
    {
      mouseX = Mathf.Clamp(mousePosition.x, dMaxLeft, dMaxRight);
      mouseY = Mathf.Clamp(mousePosition.y, dMaxDown, dMaxUp);

      draggableObject.transform.position = new Vector3(mouseX, mouseY, draggableObject.transform.position.z);
    }
}
