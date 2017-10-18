using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnlevel1 : MonoBehaviour {
 
     public Transform Destination;      
     public string TagList = "|Player|"; 
 
     public void OnTriggerEnter(Collider other)
     {
         if (TagList.Contains(string.Format("|{0}|",other.tag))) {
             other.transform.position = Destination.transform.position;
             other.transform.rotation = Destination.transform.rotation;
         }
     }
 }