using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public CharacterBase _character = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown( 0 ) )
        {
            _character.PlayAnimation(AnimationSetScriptableObject.AnimationSetNameLabel.Fighting_Combo01, AnimationSetScriptableObject.AnimationSetNameLabel.Idle01);
        }
    }
}
