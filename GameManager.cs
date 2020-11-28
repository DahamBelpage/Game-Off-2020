using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public Animator mainMenuAnim, gameMenuAnim;

    public void MainMenuSlideOut(){
        mainMenuAnim.SetTrigger("SlideOut");
        gameMenuAnim.SetTrigger("FadeIn");
    }    
}
