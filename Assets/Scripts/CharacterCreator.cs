using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class CharacterCreator : MonoBehaviour
{
    private static CharacterCreator _instance = null;
    private PlayableCharacter playerClass = null;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(_instance);
        }

    }

    public static CharacterCreator GetInstance()
    {
        return _instance;
    }

    public void SetClass(PlayableCharacter character)
    {
        playerClass = character;
    }

    public PlayableCharacter GetClass()
    {
        return playerClass;
    }
}
