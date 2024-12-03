using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName {
        set {
            value = name;
        }
    }

    public void Init(string initName, float dailyFoodConsumption, float level){
        if (initName == "Bird"){
            Debug.Log($"{initName} eats {dailyFoodConsumption} kg of foods daily and weight {level} kg.");
        }
        else{
            Debug.Log($"{initName} eats {dailyFoodConsumption} kg of foods daily with activity level {level}");
        }
    }

    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound(){
        Debug.Log("The animal makes a sound.");
    }

    public void DisplayName(){
        Debug.Log($"This is a {this.name}");
    }
}
