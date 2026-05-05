using AnchorSimTrafficMark;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(72, 73, 17, 16, 5);
        if (Policy.Score(signalcase_1) != 106) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(95, 83, 24, 5, 12);
        if (Policy.Score(signalcase_2) != 224) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(76, 79, 19, 6, 12);
        if (Policy.Score(signalcase_3) != 192) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
