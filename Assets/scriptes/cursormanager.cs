using UnityEngine;

public class cursormanager : MonoBehaviour
{
    [SerializeField] private Texture2D cursornormal;
    [SerializeField] private Texture2D cursorshoot;
    [SerializeField] private Texture2D cursorreload;
    private Vector2 hotSpot = new Vector2(16,48);
    void Start()
    {
        Cursor.SetCursor(cursornormal, hotSpot, CursorMode.Auto);
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Left click
            Cursor.SetCursor(cursorshoot, hotSpot, CursorMode.Auto);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            // Right click
            Cursor.SetCursor(cursornormal, hotSpot, CursorMode.Auto);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            Cursor.SetCursor(cursorreload, hotSpot, CursorMode.Auto);
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            Cursor.SetCursor(cursornormal, hotSpot, CursorMode.Auto);
        }
        {

        }
    }
}
