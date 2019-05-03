using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
     public static UIManager instance;
     public static UIManager Instance
     {
          get
          {
               if(instance == null)
               {
                    Debug.LogError("UIManager instance is null");
               }
               return instance;
          }
     }


     public Animator anim;
     public int currentAnim;
   
     public int CurrentAnim {
          get {

               return currentAnim;
          }

          set
          {
               currentAnim = value;
               if (currentAnim == 1)
               {
                    label.SetActive(true);
               }

               else
               {
                    label.SetActive(false);
               }
          }
     }
     public GameObject label;
   
     private void Awake()
     {
          instance = this;
          label.SetActive(false);
     }
   
     public void Next()
     {
          if(CurrentAnim == 2)
          {
               return;
          }
          CurrentAnim++;
          anim.SetInteger("NextAnim", CurrentAnim);
     }

   public void Previous()
     {
          if (CurrentAnim == 0)
          {
               return;
          }
          CurrentAnim--;
          anim.SetInteger("NextAnim", CurrentAnim);
     }
}
