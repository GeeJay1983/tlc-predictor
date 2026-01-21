/// <summary>
/// Helper class containing methods for user interaction and scene value calculation.
/// </summary>
internal static class Helper
{
    /// <summary>
    /// Prompts the user to select a scene variant from a list of options.
    /// </summary>
    /// <typeparam name="T">The enum type representing scene choices.</typeparam>
    /// <param name="scene">The scene number.</param>
    /// <param name="description">Description of the scene choice.</param>
    /// <param name="options">Array of available scene options.</param>
    /// <returns>The integer value of the selected scene choice.</returns>
    public static int GetSceneValue<T>(int scene, string description, ScenePair<T>[] options) where T : Enum
        => GetSceneValue(scene, description, options, true);
    
    /// <summary>
    /// Prompts the user to select a scene variant from a list of options with optional screen clearing.
    /// </summary>
    /// <typeparam name="T">The enum type representing scene choices.</typeparam>
    /// <param name="scene">The scene number.</param>
    /// <param name="description">Description of the scene choice.</param>
    /// <param name="options">Array of available scene options.</param>
    /// <param name="clearScreen">Whether to clear the console screen before displaying options.</param>
    /// <returns>The integer value of the selected scene choice.</returns>
    public static int GetSceneValue<T>(int scene, string description, ScenePair<T>[] options, bool clearScreen) where T : Enum
    {
        if (clearScreen)
        {
            Console.Clear();
        }

        WriteSceneTitle(scene, description);

        WriteOptions(options);

        var choice = GetChoice(options.Length);

        var chosenScenePair = options[choice];

        return (int)(object)chosenScenePair.SceneChoice;
    }

    /// <summary>
    /// Prompts the user to select from a list of string options.
    /// </summary>
    /// <param name="scene">The scene number.</param>
    /// <param name="description">Description of the scene choice.</param>
    /// <param name="options">Array of available options as strings.</param>
    /// <returns>The zero-based index of the selected option.</returns>
    public static int GetSceneValue(int scene, string description, string[] options)
    {
        Console.Clear();

        WriteSceneTitle(scene, description);

        WriteOptions(options);

        var choice = GetChoice(options.Length);

        return choice;
    }

    /// <summary>
    /// Calculates the combined scene value for scenes 9 and 10 based on user choices.
    /// </summary>
    /// <param name="scene9Value">The selected value for scene 9 (0=Reasonable, 1=Seduced).</param>
    /// <param name="scene10Value">The selected value for scene 10 (0=No nudity, 1=With nudity).</param>
    /// <returns>The combined enum value representing both scene choices.</returns>
    public static Scenes7_8_9_10_11_12 GetScene9And10Value(int scene9Value, int scene10Value)
    {
        if (scene9Value == 1)
        {
            if (scene10Value == 1)
            {
                return Scenes7_8_9_10_11_12.Scene9MichaelIsSeduced_Scene10MoreExplicit;
            }

            return Scenes7_8_9_10_11_12.Scene9MichaelIsSeduced_Scene10LessExplicit;
        }

        if (scene10Value == 1)
        {
            return Scenes7_8_9_10_11_12.Scene9MichaelIsReasonable_Scene10MoreExplicit;
        }

        return Scenes7_8_9_10_11_12.Scene9MichaelIsReasonable_Scene10LessExplicit;
    }

    /// <summary>
    /// Calculates the combined scene value for scenes 11 and 12 based on user choices.
    /// </summary>
    /// <param name="scene11Value">The selected value for scene 11 (0=No nudity, 1=With nudity).</param>
    /// <param name="scene12Value">The selected value for scene 12 (0=No nudity, 1=With nudity).</param>
    /// <returns>The combined enum value representing both scene choices.</returns>
    public static Scenes7_8_9_10_11_12 GetScene11And12Value(int scene11Value, int scene12Value)
    {
        if (scene11Value == 1)
        {
            if (scene12Value == 1)
            {
                return Scenes7_8_9_10_11_12.Scene11MoreExplicit_Scene12MoreExplicit;
            }

            return Scenes7_8_9_10_11_12.Scene11MoreExplicit_Scene12LessExplicit;
        }

        if (scene12Value == 1)
        {
            return Scenes7_8_9_10_11_12.Scene11LessExplicit_Scene12MoreExplicit;
        }

        return Scenes7_8_9_10_11_12.Scene11LessExplicit_Scene12LessExplicit;
    }

    /// <summary>
    /// Calculates the combined scene value for scenes 13 and 14 based on user choices.
    /// </summary>
    /// <param name="scene13Value">The selected value for scene 13 (0=No nudity, 1=With nudity).</param>
    /// <param name="scene14Value">The selected value for scene 14 (0-2, different argument types).</param>
    /// <returns>The combined enum value representing both scene choices.</returns>
    public static Scenes13_14_15_16 GetScene13And14Value(int scene13Value, int scene14Value)
    {
        if (scene13Value == 1)
        {
            return scene14Value switch
            {
                1 => Scenes13_14_15_16.Scene13MoreExplicit_Scene14AboutSeatbelt,
                2 => Scenes13_14_15_16.Scene13MoreExplicit_Scene14MichaelAboutRelation,
                _ => Scenes13_14_15_16.Scene13MoreExplicit_Scene14MichaelLikesToKill,
            };
        }

        return scene14Value switch
        {
            1 => Scenes13_14_15_16.Scene13LessExplicit_Scene14AboutSeatbelt,
            2 => Scenes13_14_15_16.Scene13LessExplicit_Scene14MichaelAboutRelation,
            _ => Scenes13_14_15_16.Scene13LessExplicit_Scene14MichaelLikesToKill,
        };
    }

    private static string GetEqualSigns(int sceneNumber)
    {
        if (sceneNumber >= 10)
        {
            return "==";
        }

        return "=";
    }

    private static void WriteSceneTitle(int sceneNumber, string description)
    {
        Console.WriteLine();
        Console.WriteLine($"SCENE {sceneNumber}");
        Console.Write($"======{GetEqualSigns(sceneNumber)}");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
    }

    private static void WriteOptions<T>(ScenePair<T>[] options) where T : Enum
    {
        for (var i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i].SceneDescription}");
        }

        Console.WriteLine();
    }

    private static void WriteOptions(string[] options)
    {
        for (var i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }

        Console.WriteLine();
    }

    private static bool ValidateInput(ConsoleKeyInfo input, int max, out int choice)
    {
        choice = -1;

        if (int.TryParse(input.KeyChar.ToString(), out var parsedChoice) && parsedChoice >= 1 && parsedChoice <= max)
        {
            choice = parsedChoice;

            return true;
        }

        return false;
    }

    private static int GetChoice(int max)
    {
        var input = Console.ReadKey(intercept: true);
        int choice;

        while (!ValidateInput(input, max, out choice))
        {
            Console.WriteLine($"Please input a number (1-{max})");

            input = Console.ReadKey(intercept: true);
        }

        return choice - 1;
    }
}