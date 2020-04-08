//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity bubbleConnectorEntity { get { return GetGroup(GameMatcher.BubbleConnector).GetSingleEntity(); } }
    public BubbleConnector bubbleConnector { get { return bubbleConnectorEntity.bubbleConnector; } }
    public bool hasBubbleConnector { get { return bubbleConnectorEntity != null; } }

    public GameEntity SetBubbleConnector(UnityEngine.UI.Extensions.UILineConnector newValue) {
        if (hasBubbleConnector) {
            throw new Entitas.EntitasException("Could not set BubbleConnector!\n" + this + " already has an entity with BubbleConnector!",
                "You should check if the context already has a bubbleConnectorEntity before setting it or use context.ReplaceBubbleConnector().");
        }
        var entity = CreateEntity();
        entity.AddBubbleConnector(newValue);
        return entity;
    }

    public void ReplaceBubbleConnector(UnityEngine.UI.Extensions.UILineConnector newValue) {
        var entity = bubbleConnectorEntity;
        if (entity == null) {
            entity = SetBubbleConnector(newValue);
        } else {
            entity.ReplaceBubbleConnector(newValue);
        }
    }

    public void RemoveBubbleConnector() {
        bubbleConnectorEntity.Destroy();
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

    public BubbleConnector bubbleConnector { get { return (BubbleConnector)GetComponent(GameComponentsLookup.BubbleConnector); } }
    public bool hasBubbleConnector { get { return HasComponent(GameComponentsLookup.BubbleConnector); } }

    public void AddBubbleConnector(UnityEngine.UI.Extensions.UILineConnector newValue) {
        var index = GameComponentsLookup.BubbleConnector;
        var component = CreateComponent<BubbleConnector>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBubbleConnector(UnityEngine.UI.Extensions.UILineConnector newValue) {
        var index = GameComponentsLookup.BubbleConnector;
        var component = CreateComponent<BubbleConnector>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBubbleConnector() {
        RemoveComponent(GameComponentsLookup.BubbleConnector);
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

    static Entitas.IMatcher<GameEntity> _matcherBubbleConnector;

    public static Entitas.IMatcher<GameEntity> BubbleConnector {
        get {
            if (_matcherBubbleConnector == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BubbleConnector);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBubbleConnector = matcher;
            }

            return _matcherBubbleConnector;
        }
    }
}