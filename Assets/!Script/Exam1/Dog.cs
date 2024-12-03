using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption = 0.4f;

    private int activityLevel = 2;

    private float result;

    public override float CalculateFoodRequirement()
    {
        result = dailyFoodConsumption * activityLevel * 7;
        return result;
    }

    public override void MakeSound()
    {
        base.MakeSound();

        Debug.Log($"{name} barks Woof! Woof!");
    }

    void Start(){
        DisplayName();
        MakeSound();
        Init(this.name, dailyFoodConsumption, activityLevel);
        Debug.Log($"{this.name}'s weekly food requirement : {CalculateFoodRequirement()} kg.");
    }

}
