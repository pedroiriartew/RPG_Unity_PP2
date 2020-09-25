using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerActor : MonoBehaviour
{
    [SerializeField]
    private PlayableCharacter character = null;

    private float horizontalMovement = 0f;
    private float jumpVelocity = 8f;
    private bool bJump = false;

    private Camera cam;

    public event Action OpenCloseInventory;

    private void Awake()
    {
        SetCharacter();

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

    public void SetCharacter()
    {
        string json = File.ReadAllText(Application.dataPath + "/characterFile.json");

        CharacterData characterData = JsonUtility.FromJson<CharacterData>(json);

        if (characterData.GetDataCharacterClass() == "Rogue")
        {
            character = new Rogue();
            character.SetNewStats(characterData.GetDataStats());
            character.SetInventory(characterData.GetDataInventory());
        }

        if (characterData.GetDataCharacterClass() == "Sorcerer")
        {
            character = new Sorcerer();
            character.SetNewStats(characterData.GetDataStats());
            character.SetInventory(characterData.GetDataInventory());
        }

        if (characterData.GetDataCharacterClass() == "Warrior")
        {
            character = new Warrior();
            character.SetNewStats(characterData.GetDataStats());
            character.SetInventory(characterData.GetDataInventory());
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
