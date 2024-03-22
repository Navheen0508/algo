using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MonsterLevel
{
    public int cost; 
    public GameObject visualization; 
}

public class Monster : MonoBehaviour
{
    public List<MonsterLevel> levels; 

    private MonsterLevel currentLevel; 

   // public void OnEnable()
   //{
       // CurrentLevel = levels[0];
    //}

    //public MonsterLevel Current level()
    //{
        //get { return currentLevel; }
        //set
        //{
        //    currentLevel = value;
        //}

   // }

   // public MonsterLevel GetNextLevel()
    //{
        

   // }

}