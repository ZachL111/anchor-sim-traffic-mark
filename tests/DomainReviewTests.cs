using AnchorSimTrafficMark;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(77, 30, 24, 48);
        if (DomainReviewLens.Score(item) != 160) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
