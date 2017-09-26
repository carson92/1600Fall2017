//Logical operators are seperated into 3 main operators, the && (or the logical and operator) which makes anything that both intergers are nonzero true. 
//Another logical operater is the || (or the logical or operator) which makes the condition true if either of the intergers are non zero. 
//The third logical operator is th !( && ) (or the logical not operator) which will revers the logical state, is the state is true, then it will make it false.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {
 	public bool a = true; 
        public bool b = true;
        public bool pizza = true;
        public bool apple = true;


        void Start()
        { 
         if (a && b)
         {
            print("Line 1 - Condition is true");
         }
         
         if (a || b)
         {
            print("Line 2 - Condition is true");
         }
         a = false;
         b = true;
         
         if (a && b)
         {
            print("Line 3 - Condition is true");
         }
         else
         {
            print("Line 3 - Condition is not true");
         }
         
         if (!(a && b))
         {
            print("Line 4 - Condition is true");
         }
        if (pizza && apple)
        {
                print("Line 1 - Its true boi");
        }
        if (pizza || apple)
        {
                print("Line 2 - Its true boi");
        }
        pizza = false; 
        apple = true; 

        if (pizza && apple)
        {
                print("Line 3 - Its true boi");
        }
        else{
                print("Its not true son!");
        }
        if (!(pizza && apple))
        {
                print("Its true boi");
        }
        }
}
