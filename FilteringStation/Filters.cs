namespace FilteringStation
{
    public enum Filters
    {
        Null = 0,
        
        LinearArythmetic = 2,
        LinearGeometric = 4,
        LinearHarmonic = 6,
        LinearCounterHarmonic = 8,
        LinearGaussian = 10,

        NonLinearMedian = 1,
        NonLinearStaticstical = 3,
        NonLinearKurahawa = 5,
        NonLinearAdaptiveBinary = 7
    }
}