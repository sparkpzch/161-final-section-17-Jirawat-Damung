using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast(){
        Debug.Log("Casting a generic spell!");
    }

    public void Cast (string enemyName){
        Debug.Log($"Casting a {this.name} on {enemyName}!");
    }

    public void Cast (String enemyName, int castLevel){
        Debug.Log($"Casting a {this.name} with Power : {castLevel} on {enemyName}!");
    }
}
