using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Casting an Electric Shock Spell! Shock the enemy!");
    }

    public void Debuff()
    {
        Debug.Log("Enemy is Shocking can't move now");
    }

    private void Start()
    {
        Cast();
        Cast("Orc");
        Cast("Orc", 30);
        Debuff();
    }
}
