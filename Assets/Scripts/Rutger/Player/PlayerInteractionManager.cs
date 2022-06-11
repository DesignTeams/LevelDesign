using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractionManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public TMPro.TextMeshProUGUI interactionText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(items.Count > 0)
        {
            interactionText.SetText("Press E to pickup "+items[0].itemName);
        }
        else
        {
            interactionText.SetText("");
        }
    }

    public void TryPickup(InputAction.CallbackContext context)
    {
        foreach(Item item in items)
        {
            item.PickUp();
        }
        items.Clear();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Item>() != null)
        {
            items.Add(other.GetComponent<Item>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Item>() != null)
        {
            items.Remove(other.GetComponent<Item>());
        }
    }
}
