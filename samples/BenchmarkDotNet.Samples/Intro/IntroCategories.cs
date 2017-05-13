using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Filters;
using BenchmarkDotNet.Attributes.Jobs;

namespace BenchmarkDotNet.Samples.Intro
{
    [DryJob]
    [CategoriesColumn]
    [BenchmarkCategory("Awesome")]
    [AnyCategoriesFilter("A", "1")]
    public class IntroCategories
    {
        [Benchmark]
        [BenchmarkCategory("A", "1")]
        public void A1() => Thread.Sleep(10); // Will be benchmarked
        
        [Benchmark]
        [BenchmarkCategory("A", "2")]
        public void A2() => Thread.Sleep(10); // Will be benchmarked

        [Benchmark]
        [BenchmarkCategory("B", "1")]
        public void B1() => Thread.Sleep(10); // Will be benchmarked
        
        [Benchmark]
        [BenchmarkCategory("B", "2")]
        public void B2() => Thread.Sleep(10);
    }
}