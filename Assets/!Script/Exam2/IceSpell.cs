using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Casting an Ice Shard Spell! Freeze the enemy!");
    }

    private void Start()
    {
        Cast();
        Cast("Goblin");
        Cast("Goblin", 10);
    }
}
