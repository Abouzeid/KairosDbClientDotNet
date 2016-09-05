namespace KairosDbClient.Aggregators.Range
{
    public class GapsAggregator : RangeAggregator
    {
        public GapsAggregator(int value, TimeUnit unit) : base("gaps", value, unit)
        {
            
        }
    }
}
