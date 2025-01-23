
Console.Clear();
Console.WriteLine(
@"Welcome to the Tender Loving Care Movie Code Generator!
=======================================================
                (C) 2025 GJ Jaarsma


This tool will ask you a series of questions about several scenes to get exactly the version that you want to see.

So... Let's begin!

");

Console.WriteLine("The intro sequence and SCENE 1 always play out exactly the same. So, no choices here.");

var optionsScene2 = new ScenePair<Scenes2_4_5_6>[] 
{
    new(Scenes2_4_5_6.Scene2KathrynIsDressed, "Kathryn appears in her underwear, while Michael 'accidentally' watches her"),
    new(Scenes2_4_5_6.Scene2KathrynUndressing, "Kathryn appears while removing her bra, while Michael 'accidentally' watches her"),
    new(Scenes2_4_5_6.Scene2PeekKathrynUndressing, "Michael sneaks below Kathryn's window, as he watches her undress")
};

var scene2Value = Helper.GetSceneValue(2, "How will Michael watch Kathryn at her bedroom window?", optionsScene2, clearScreen: false);

Console.Clear();

Console.WriteLine("SCENE 3 always play out exactly the same. So, no choices here.");

var optionsScene4 = new ScenePair<Scenes2_4_5_6>[]
{
    new(Scenes2_4_5_6.Scene4KathrynOffersSpongeBath, "Kathryn will invitingly offer Michael a sponge bath"),
    new(Scenes2_4_5_6.Scene4KathrynGivesGroceryList, "Kathryn will give Michael a list of groceries"),
    new(Scenes2_4_5_6.Scene4MichaelOffersSpongeBath, "Michael will sarcastically offer Kathryn a sponge bath")
};

var scene4Value = Helper.GetSceneValue(4, "How will the conversation between Kathryn and Michael above the stairs unfold?", optionsScene4, clearScreen: false);

var optionsScene5 = new ScenePair<Scenes2_4_5_6>[]
{
    new(Scenes2_4_5_6.Scene5KathrynPredictsBehavior, "Allison says that Kathryn predicted Michael's behavior"),
    new(Scenes2_4_5_6.Scene5MichaelIsReluctant, "Michael is reluctant in getting stuff from Jody's room"),
    new(Scenes2_4_5_6.Scene5MichaelIsAngry, "Michael gets angry at Allison")
};

var scene5Value = Helper.GetSceneValue(5, "How will the conversation between Allison and Michael on the porch unfold?", optionsScene5);

var optionsScene6 = new ScenePair<Scenes2_4_5_6>[]
{
    new(Scenes2_4_5_6.Scene6KathrynIsAngry, "Kathryn gets angry at Michael and pushes him aside walking out of the room"),
    new(Scenes2_4_5_6.Scene6KathrynIsAnnoyed, "Kathryn gets annoyed and tells Michael to let her do her work"),
    new(Scenes2_4_5_6.Scene6MichaelIsAngry, "Michael gets angry at Kathryn")
};

var scene6Value = Helper.GetSceneValue(6, "How will the conversation between Kathryn and Michael in Jody's bedroom unfold?", optionsScene6);

var optionsScene7 = new ScenePair<Scenes7_8_9_10_11_12>[]
{
    new(Scenes7_8_9_10_11_12.Scene7MichaelIsAngry, "Michael gets angry when asked about the meditation sessions with Kathryn"),
    new(Scenes7_8_9_10_11_12.Scene7MichaelIsNeutral, "Michael reacts neutral to meditation with Kathryn"),
    new(Scenes7_8_9_10_11_12.Scene7KathrynAndAllisonLaugh, "Allison and Kathryn are playfully teasing Michael about Kathryn's mediation sessions")
};

var scene7Value = Helper.GetSceneValue(7, "How will the conversation between Michael, Allison and Kathryn in the kitchen unfold?", optionsScene7);

var optionsScene8 = new ScenePair<Scenes7_8_9_10_11_12>[]
{
    new(Scenes7_8_9_10_11_12.Scene8CharlotteInvites, "Charlotte is inviting towards Michael, she seems to like him"),
    new(Scenes7_8_9_10_11_12.Scene8CharlotteIsRejected, "Charlotte tries to get closer to Michael, but he isn't having it"),
    new(Scenes7_8_9_10_11_12.Scene8CharlotteFlirts, "Charlotte flirts with Michael, and he seems to like it")
};

var scene8Value = Helper.GetSceneValue(8, "At Michael's work, how will he interact with his collegue Charlotte?", optionsScene8);

var optionsScene9 = new[] 
{
    "Reasonable",
    "Seduced"
};

var scene9Value = Helper.GetSceneValue(9, "Will Michael have a fairly reasonable conversation with Kathryn, or will he be seduced by Kathryn?", optionsScene9);

var optionsYesNo = new[]
{
    "No",
    "Yes"
};

var scene10Value = Helper.GetSceneValue(10, "Will the meditation scene feature nudity?", optionsYesNo);

var scene9And10Value = (int)Helper.GetScene9And10Value(scene9Value, scene10Value);

var scene11Value = Helper.GetSceneValue(11, "Will the scenes at Kathryn's room feature nudity?", optionsYesNo);

var scene12Value = Helper.GetSceneValue(12, "Will the scene at Jody's and Kathryn's room feature nudity?", optionsYesNo);

var scene11And12Value = (int)Helper.GetScene11And12Value(scene11Value, scene12Value);

var scene13Value = Helper.GetSceneValue(13, "Will the scene at Kathryn's room feature nudity?", optionsYesNo);

var optionsScene14 = new string[]
{
    "Kathryn says that Michael likes to kill",
    "Kathryn will emphasize that Jody's situation is Michael's fault, because he didn't let her wear the seatbelt",
    "Michael tries to talk about Kathryn previous relations"
};

var scene14Value = Helper.GetSceneValue(14, "How will the arguing scene between Michael and Kathryn unfold?", optionsScene14);

var scene13And14Value = (int)Helper.GetScene13And14Value(scene13Value, scene14Value);

var optionsScene15 = new ScenePair<Scenes13_14_15_16>[]
{
    new(Scenes13_14_15_16.Scene15WatchOutForKathryn, "Mrs. Greenstreet warns Michael to watch out for Kathryn"),
    new(Scenes13_14_15_16.Scene15TurnerWillUnderstand, "Michael tells Mrs. Greenstreet that Dr. Turner will understand"),
    new(Scenes13_14_15_16.Scene15MichaelNeedsHelp, "Mrs. Greenstreet tells Michael that he needs help"),
};

var scene15Value = Helper.GetSceneValue(15, "How will the conversation between Mrs. Greenstreet and Michael at Turner's office unfold?", optionsScene15);

var optionsEnding = new ScenePair<Scenes13_14_15_16>[]
{
    new (Scenes13_14_15_16.Scene16KathrynDiesNoTurnerNoRecovery, "Kathryn dies, Michael and Allison return to their state of denial"),
    new (Scenes13_14_15_16.Scene16KathrynDiesWithTurnerNoRecovery, "Kathryn dies, Turner shows up and finds out about Kathryn"),
    new (Scenes13_14_15_16.Scene16KathrynDiesNoTurnerRecovery, "Kathryn dies, Michael and Allison return to their state of denial, but are partially recovered"),
    new (Scenes13_14_15_16.Scene16KathrynBecomesJody, "Kathryn is disabled and becomes fantasy Jody"),
    new (Scenes13_14_15_16.Scene16MichaelDiesKathrynTakesCare, "Michael dies, Kathryn takes care of Allison"),
    new (Scenes13_14_15_16.Scene16KathrynIsHurtRecovery, "Kathryn is hurt and taken to hospital. Michael and Allison return to their state of denial"),
    new (Scenes13_14_15_16.Scene16KathrynIsHurtNoRecovery, "Kathryn is hurt and taken to hospital. Michael and Allison return to their state of denial, but are partially recovered"),
};

var endingValue = Helper.GetSceneValue(16, "What ending will the movie have?", optionsEnding);

var input1 = scene2Value + scene4Value + scene5Value + scene6Value;
var input2 = scene7Value + scene8Value + scene9And10Value + scene11And12Value;
var input3 = scene13And14Value + scene15Value + endingValue;
var input4 = 0x0F;
var input9 = input1 + input2 + input3 + input4;
var input9Value = $"{input9:X}";
var input9Shortvalue = input9Value.Length > 2 ? input9Value.Substring(1, 2) : input9Value;

Console.WriteLine();
Console.WriteLine("You will get this version if you use the following inputs for restoring the session:");
Console.WriteLine($"1: {input1:X}");
Console.WriteLine($"2: {input2:X}");
Console.WriteLine($"3: {input3:X}");
Console.WriteLine("4: 0F");
Console.WriteLine("5: 00");
Console.WriteLine("6: 00");
Console.WriteLine("7: 00");
Console.WriteLine("8: 00");
Console.WriteLine($"9: {input9Shortvalue}");