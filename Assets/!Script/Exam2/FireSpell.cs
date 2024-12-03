using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Casting a {this.name}! Burn them all!");
    }

    private void Start()
    {
        Cast();
        Cast("Slime");
        Cast("Slime", 5);
    }
}
