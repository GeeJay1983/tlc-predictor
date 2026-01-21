/// <summary>
/// Container class for scene-related types and enums.
/// </summary>
internal static class Scenes
{
}

/// <summary>
/// Represents a scene choice pairing an enum value with a human-readable description.
/// </summary>
/// <typeparam name="T">The enum type representing the scene choice.</typeparam>
internal sealed class ScenePair<T>(T sceneChoice, string sceneDescription) where T : Enum
{
    public T SceneChoice { get; } = sceneChoice;

    public string SceneDescription { get; } = sceneDescription;
}

/// <summary>
/// Enum representing scene choices for scenes 2, 4, 5, and 6.
/// Values are hex-encoded bit patterns used in the DVD session code calculation.
/// </summary>
enum Scenes2_4_5_6
{
    Default = 0x0,
    Scene2KathrynUndressing = 0x40,
    Scene2KathrynIsDressed = 0x80,
    Scene2PeekKathrynUndressing = 0xC0,
    Scene4KathrynOffersSpongeBath = 0x10,
    Scene4KathrynGivesGroceryList = 0x20,
    Scene4MichaelOffersSpongeBath = 0x30,
    Scene5KathrynPredictsBehavior = 0x04,
    Scene5MichaelIsReluctant = 0x08,
    Scene5MichaelIsAngry = 0x0C,
    Scene6KathrynIsAngry = 0x01,
    Scene6KathrynIsAnnoyed = 0x02,
    Scene6MichaelIsAngry = 0x03
}

/// <summary>
/// Enum representing scene choices for scenes 7, 8, 9, 10, 11, and 12.
/// Values are hex-encoded bit patterns used in the DVD session code calculation.
/// </summary>
enum Scenes7_8_9_10_11_12
{
    Default = 0x0,
    Scene7MichaelIsAngry = 0x40,
    Scene7MichaelIsNeutral = 0x80,
    Scene7KathrynAndAllisonLaugh = 0xC0,
    Scene8CharlotteInvites = 0x10,
    Scene8CharlotteIsRejected = 0x20,
    Scene8CharlotteFlirts = 0x30,
    Scene9MichaelIsReasonable_Scene10MoreExplicit = 0x0,
    Scene9MichaelIsReasonable_Scene10LessExplicit = 0x04,
    Scene9MichaelIsSeduced_Scene10MoreExplicit = 0x08,
    Scene9MichaelIsSeduced_Scene10LessExplicit = 0x0C,
    Scene11MoreExplicit_Scene12MoreExplicit = 0x0,
    Scene11MoreExplicit_Scene12LessExplicit = 0x01,
    Scene11LessExplicit_Scene12MoreExplicit = 0x02,
    Scene11LessExplicit_Scene12LessExplicit = 0x03
}

/// <summary>
/// Enum representing scene choices for scenes 13, 14, 15, and 16.
/// Values are hex-encoded bit patterns used in the DVD session code calculation.
/// </summary>
enum Scenes13_14_15_16
{
    Default = 0x0,
    Scene13MoreExplicit_Scene14MichaelLikesToKill = 0x20,
    Scene13MoreExplicit_Scene14AboutSeatbelt = 0x40,
    Scene13MoreExplicit_Scene14MichaelAboutRelation = 0x60,
    Scene13LessExplicit_Scene14MichaelLikesToKill = 0xA0,
    Scene13LessExplicit_Scene14AboutSeatbelt = 0xC0,
    Scene13LessExplicit_Scene14MichaelAboutRelation = 0xE0,
    Scene15WatchOutForKathryn = 0x08,
    Scene15TurnerWillUnderstand = 0x10,
    Scene15MichaelNeedsHelp = 0x18,
    Scene16KathrynDiesNoTurnerNoRecovery = 0x01,
    Scene16KathrynDiesWithTurnerNoRecovery = 0x02,
    Scene16KathrynDiesNoTurnerRecovery = 0x03,
    Scene16KathrynBecomesJody = 0x04,
    Scene16MichaelDiesKathrynTakesCare = 0x05,
    Scene16KathrynIsHurtRecovery = 0x06,
    Scene16KathrynIsHurtNoRecovery = 0x07
}