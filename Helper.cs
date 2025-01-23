internal static class Helper
{
    public static int GetSceneValue<T>(int scene, string description, ScenePair<T>[] options) where T : Enum
        => GetSceneValue(scene, description, options, true);
    
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

    public static int GetSceneValue(int scene, string description, string[] options)
    {
        Console.Clear();

        WriteSceneTitle(scene, description);

        WriteOptions(options);

        var choice = GetChoice(options.Length);

        return choice;
    }

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

        if (int.TryParse(input.KeyChar.ToString(), out var parsedChoice) && parsedChoice <= max)
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