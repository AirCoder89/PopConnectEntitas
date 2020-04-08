//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CallBackComponent callBack { get { return (CallBackComponent)GetComponent(GameComponentsLookup.CallBack); } }
    public bool hasCallBack { get { return HasComponent(GameComponentsLookup.CallBack); } }

    public void AddCallBack(System.Action newValue) {
        var index = GameComponentsLookup.CallBack;
        var component = CreateComponent<CallBackComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCallBack(System.Action newValue) {
        var index = GameComponentsLookup.CallBack;
        var component = CreateComponent<CallBackComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCallBack() {
        RemoveComponent(GameComponentsLookup.CallBack);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCallBack;

    public static Entitas.IMatcher<GameEntity> CallBack {
        get {
            if (_matcherCallBack == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CallBack);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCallBack = matcher;
            }

            return _matcherCallBack;
        }
    }
}
