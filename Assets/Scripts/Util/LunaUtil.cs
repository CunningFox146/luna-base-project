namespace PlayableAd.Util
{
    using Luna.Unity;

    public static class LunaUtils
    {
        private const string TutorialKey = "Tutorial_Over";
        private const string WinKey = "AdOver_Win";
        private const string LoseKey = "AdOver_Lose";
        private const string FakeKey = "AdOver_Fake";
        private const string ConvertKey = "Convert_Game";
        private const string IntroEndKey = "Intro_End";
        private const string ConvertWinKey = "Convert_Win";
        private const string ConvertLoseKey = "Convert_Lose";
        private const string ConvertFakeKey = "Convert_Fake";
        private const string AutoWinKey = "AdOver_AutoWin";
        private const string ConvertAutoWinKey = "Convert_AutoWin";
        private const string TrashCollectKey = "Trash_Collect";

        public static void TutorialOver() => LogEvent(TutorialKey);
        public static void WinGame() => LogEvent(WinKey);
        public static void LoseGame() => LogEvent(LoseKey);
        public static void FakeGame() => LogEvent(FakeKey);
        public static void ConvertGame() => LogEvent(ConvertKey);
        public static void IntroEnd() => LogEvent(IntroEndKey);
        public static void ConvertWin() => LogEvent(ConvertWinKey);
        public static void ConvertLose() => LogEvent(ConvertLoseKey);
        public static void ConvertFake() => LogEvent(ConvertFakeKey);
        public static void AutoWin() => LogEvent(AutoWinKey);
        public static void AutoConvert() => LogEvent(ConvertAutoWinKey);
    
        public static void EndGame() => LifeCycle.GameEnded();
        public static void OpenStore() => Playable.InstallFullGame();
        public static void CollectTrash() => LogEvent(TrashCollectKey);

        private static void LogEvent(Analytics.EventType eventType) => Analytics.LogEvent(eventType);
        private static void LogEvent(string name) => Analytics.LogEvent(name, 0);

    }
}