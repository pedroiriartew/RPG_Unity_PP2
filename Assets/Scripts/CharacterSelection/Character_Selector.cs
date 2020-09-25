using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Character_Selector : MonoBehaviour
{
    private PlayableCharacter newCharacter = null;
    private CharacterData newCharacterData = new CharacterData();

    public void CreateWarrior()
    {
        newCharacter = new Warrior();
        newCharacterData.SetData(newCharacter.GetStats(), newCharacter.GetInventory(), newCharacter.GetClassName());

        string json = JsonUtility.ToJson(newCharacterData);     

        File.WriteAllText(Application.dataPath + "/characterFile.json", json);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreateSorcerer()
    {
        newCharacter = new Sorcerer();
        newCharacterData.SetData(newCharacter.GetStats(), newCharacter.GetInventory(), newCharacter.GetClassName());

        string json = JsonUtility.ToJson(newCharacterData);

        File.WriteAllText(Application.dataPath + "/characterFile.json", json);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreateRogue()
    {
        newCharacter = new Rogue();
        newCharacterData.SetData(newCharacter.GetStats(), newCharacter.GetInventory(), newCharacter.GetClassName());

        string json = JsonUtility.ToJson(newCharacterData);

        File.WriteAllText(Application.dataPath + "/characterFile.json", json);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
