//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity audioManagerEntity { get { return GetGroup(GameMatcher.AudioManager).GetSingleEntity(); } }
    public AudioManagerComponent audioManager { get { return audioManagerEntity.audioManager; } }
    public bool hasAudioManager { get { return audioManagerEntity != null; } }

    public GameEntity SetAudioManager(AudioManager newAudioManager) {
        if (hasAudioManager) {
            throw new Entitas.EntitasException("Could not set AudioManager!\n" + this + " already has an entity with AudioManagerComponent!",
                "You should check if the context already has a audioManagerEntity before setting it or use context.ReplaceAudioManager().");
        }
        var entity = CreateEntity();
        entity.AddAudioManager(newAudioManager);
        return entity;
    }

    public void ReplaceAudioManager(AudioManager newAudioManager) {
        var entity = audioManagerEntity;
        if (entity == null) {
            entity = SetAudioManager(newAudioManager);
        } else {
            entity.ReplaceAudioManager(newAudioManager);
        }
    }

    public void RemoveAudioManager() {
        audioManagerEntity.Destroy();
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

    public AudioManagerComponent audioManager { get { return (AudioManagerComponent)GetComponent(GameComponentsLookup.AudioManager); } }
    public bool hasAudioManager { get { return HasComponent(GameComponentsLookup.AudioManager); } }

    public void AddAudioManager(AudioManager newAudioManager) {
        var index = GameComponentsLookup.AudioManager;
        var component = CreateComponent<AudioManagerComponent>(index);
        component.audioManager = newAudioManager;
        AddComponent(index, component);
    }

    public void ReplaceAudioManager(AudioManager newAudioManager) {
        var index = GameComponentsLookup.AudioManager;
        var component = CreateComponent<AudioManagerComponent>(index);
        component.audioManager = newAudioManager;
        ReplaceComponent(index, component);
    }

    public void RemoveAudioManager() {
        RemoveComponent(GameComponentsLookup.AudioManager);
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

    static Entitas.IMatcher<GameEntity> _matcherAudioManager;

    public static Entitas.IMatcher<GameEntity> AudioManager {
        get {
            if (_matcherAudioManager == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AudioManager);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAudioManager = matcher;
            }

            return _matcherAudioManager;
        }
    }
}
