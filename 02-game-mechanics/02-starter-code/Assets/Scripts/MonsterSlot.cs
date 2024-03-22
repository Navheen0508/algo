using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSlot : MonoBehaviour
{

  public GameObject MonsterPrefab;
  private GameObject placedMonster = null; 

  void OnMouseUp()
  {
    if (placedMonster == null) 
    {

      placedMonster = Instantiate(MonsterPrefab, transform.position, Quaternion.identity);
  
    }
  }
  
}
