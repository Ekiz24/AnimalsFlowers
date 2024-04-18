using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    //all the scences have Audio Source with this script

    static BGM Music; //is used to store the unique instance of background music

    void Awake()
    {
        //these are for keeping background music playing even if we are testing other scences
        //and assuring there is always only one background music throughout the play
        if (Music == null) //checks whether there is already an existing music instance
        {
            Music = this; //if not existing (like in the 1st scene), it assigns the current instance to Music
        }
        else
        {
            Destroy(gameObject); //if so (like in the 2nd scene), then destroy the current music instance
        }

        DontDestroyOnLoad(gameObject); //keep the only one music playing 

    }

}
