using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption = 0.2f;

    private float weight = 0.45f;

    private float result;

    public override float CalculateFoodRequirement()
    {
        result = dailyFoodConsumption * weight * 7;
        return result;
    }

    public override void MakeSound()
    {
        base.MakeSound();

        Debug.Log($"{name} Chips Tweet! Tweet!");
    }

    void Start(){
        DisplayName();
        MakeSound();
        Init(this.name, dailyFoodConsumption, weight);
        Debug.Log($"{this.name}'s weekly food requirement : {CalculateFoodRequirement()} kg.");
    }
}
