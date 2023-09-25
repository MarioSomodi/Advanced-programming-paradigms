using PostSharp.Aspects;
using System;
using System.Diagnostics;
namespace MeasureRuntimeAttribute
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class MeasureRuntime : OnMethodBoundaryAspect
    {
        private static readonly Stopwatch timer = new Stopwatch();
        public override void OnEntry(MethodExecutionArgs args)
        {
            timer.Start();
        }
        public override void OnExit(MethodExecutionArgs args)
        {
            var elapsedMilliseconds = timer.ElapsedMilliseconds;
            timer.Stop();
            Console.WriteLine("Elapsed miliseconds: " + elapsedMilliseconds);
        }
    }
}