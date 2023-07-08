using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMapView3D : View3DBase
{
    private GameObject _localMapObj = null;

    private CharacterBase _playerCharacter = null;

    public override void InitializeView()
    {
        base.InitializeView();

        LoadBg();
        LoadCharacter();
    }

    public void LoadBg()
    {
        const string BG_PATH = "3D/LocalMap/LocalMap_{0}";
        GameObject obj = ResourceManager.LoadOnView<GameObject>(Utility.StringFormat(BG_PATH, "Test01"));
        _localMapObj = Instantiate<GameObject>(obj);

        _localMapObj.transform.SetParent(transform);
    }

    public void LoadCharacter()
    {
        const string MODEL_PATH = "3D/Character/Model/{0}";
        GameObject obj = ResourceManager.LoadOnView<GameObject>(Utility.StringFormat(MODEL_PATH, "Base01"));
        _playerCharacter = Instantiate<GameObject>( obj ).GetComponent<CharacterBase>();
        _playerCharacter.Initialize();

        _playerCharacter.transform.SetParent(transform);

        CameraManager.Instance.MainCamera.LookDown.SetCharacter( _playerCharacter );
    }

    public override void DestroyView()
    {
        GameObject.Destroy(_localMapObj);
        _localMapObj = null;

        base.DestroyView();
    }
}
