using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Character_Selector : MonoBehaviour
{

    public void CreateWarrior()
    {
        CharacterCreator.GetInstance().SetClass(new Warrior());

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreateSorcerer()
    {
        CharacterCreator.GetInstance().SetClass(new Sorcerer());

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreateRogue()
    {
        CharacterCreator.GetInstance().SetClass(new Rogue());

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
