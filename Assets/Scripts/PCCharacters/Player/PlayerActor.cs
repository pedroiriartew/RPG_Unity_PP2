using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour
{
    private PlayableCharacter character = null;

    private float horizontalMovement = 0f;
    private float jumpVelocity = 8f;
    private bool bJump = false;

    private Camera cam;

    public event Action OpenCloseInventory;

    private void Awake()
    {
        //character = CharacterCreator.GetInstance().GetClass();
         character = new Rogue();

       // character.SetInventory(new InventorySystem());
        Debug.Log(character.GetInventory());

        cam = Camera.main;
    }

    public void GetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        bJump = Input.GetButtonDown("Jump");

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("La clase es " + character);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Interact();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            OpenCloseInventory?.Invoke();
        }
    }

    private void Jump()
    {
        if (bJump)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
    }

    public void MovePlayer()
    {
        Vector3 movement = new Vector3(horizontalMovement, 0f, 0f);
        transform.position += movement * Time.deltaTime * character.GetSpeed();        
    }

    public void Interact()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                if (interactable.IsItem())
                {
                    bool wasItemPickedUp = character.GetInventory().AddToInventory(interactable.GetComponent<Script_ItemPrefab>().GetItem());

                    if(wasItemPickedUp)
                        interactable.Interact();//Hago esto para no desactivar el game object, si no no podría agarrarlo de nuevo
                }
                else
                {
                    //Falta la parte del Interact del NPC
                }

                return;
            }
        }

    }

    public PlayableCharacter GetCharacter()
    {
        return character;
    }

    private void Update()
    {
        GetInput();
        MovePlayer();
        Jump();
    }

}
