using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowtoProgram7 : MonoBehaviour
{
    Player warrior;
    Player archer;

    void Start()
    {
        warrior = new Player(1, 2, "Annan");
        warrior.Attack();
        warrior.SetHealth(20);

        Debug.Log("The health of  the warrior is " + warrior.GetHealth());
    }

  
}
