//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity graphicRaycastEntity { get { return GetGroup(GameMatcher.GraphicRaycast).GetSingleEntity(); } }
    public GraphicRaycastComponent graphicRaycast { get { return graphicRaycastEntity.graphicRaycast; } }
    public bool hasGraphicRaycast { get { return graphicRaycastEntity != null; } }

    public GameEntity SetGraphicRaycast(UnityEngine.UI.GraphicRaycaster newMRaycaster, UnityEngine.EventSystems.EventSystem newMEventSystem) {
        if (hasGraphicRaycast) {
            throw new Entitas.EntitasException("Could not set GraphicRaycast!\n" + this + " already has an entity with GraphicRaycastComponent!",
                "You should check if the context already has a graphicRaycastEntity before setting it or use context.ReplaceGraphicRaycast().");
        }
        var entity = CreateEntity();
        entity.AddGraphicRaycast(newMRaycaster, newMEventSystem);
        return entity;
    }

    public void ReplaceGraphicRaycast(UnityEngine.UI.GraphicRaycaster newMRaycaster, UnityEngine.EventSystems.EventSystem newMEventSystem) {
        var entity = graphicRaycastEntity;
        if (entity == null) {
            entity = SetGraphicRaycast(newMRaycaster, newMEventSystem);
        } else {
            entity.ReplaceGraphicRaycast(newMRaycaster, newMEventSystem);
        }
    }

    public void RemoveGraphicRaycast() {
        graphicRaycastEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GraphicRaycastComponent graphicRaycast { get { return (GraphicRaycastComponent)GetComponent(GameComponentsLookup.GraphicRaycast); } }
    public bool hasGraphicRaycast { get { return HasComponent(GameComponentsLookup.GraphicRaycast); } }

    public void AddGraphicRaycast(UnityEngine.UI.GraphicRaycaster newMRaycaster, UnityEngine.EventSystems.EventSystem newMEventSystem) {
        var index = GameComponentsLookup.GraphicRaycast;
        var component = CreateComponent<GraphicRaycastComponent>(index);
        component.mRaycaster = newMRaycaster;
        component.mEventSystem = newMEventSystem;
        AddComponent(index, component);
    }

    public void ReplaceGraphicRaycast(UnityEngine.UI.GraphicRaycaster newMRaycaster, UnityEngine.EventSystems.EventSystem newMEventSystem) {
        var index = GameComponentsLookup.GraphicRaycast;
        var component = CreateComponent<GraphicRaycastComponent>(index);
        component.mRaycaster = newMRaycaster;
        component.mEventSystem = newMEventSystem;
        ReplaceComponent(index, component);
    }

    public void RemoveGraphicRaycast() {
        RemoveComponent(GameComponentsLookup.GraphicRaycast);
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

    static Entitas.IMatcher<GameEntity> _matcherGraphicRaycast;

    public static Entitas.IMatcher<GameEntity> GraphicRaycast {
        get {
            if (_matcherGraphicRaycast == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GraphicRaycast);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGraphicRaycast = matcher;
            }

            return _matcherGraphicRaycast;
        }
    }
}