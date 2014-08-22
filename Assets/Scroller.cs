using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour
{
    public float AnimationRate = 0.1f;
    protected float _uvOffset = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        float speed = AnimationRate; //( ( Globals.Speed / 20 ) );
        float infrontVal = _uvOffset + 1.0f;

        _uvOffset = Mathf.Lerp( _uvOffset, infrontVal, speed * Time.deltaTime );

        if ( _uvOffset > 1.0f )
        {
            _uvOffset -= 1.0f;
        }

        if ( renderer.enabled )
        {
            renderer.material.mainTextureOffset = new Vector2( _uvOffset, 0.0f );
        }
    }
}
