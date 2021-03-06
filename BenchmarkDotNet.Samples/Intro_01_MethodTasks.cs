﻿using System;
using BenchmarkDotNet.Tasks;

namespace BenchmarkDotNet.Samples
{
    // For some methods, logic may differ for different environments.
    public class Intro_01_MethodTasks
    {        
        [Benchmark]
        // In this case, you can declare several tasks with the Task attrbute.
        // For example, we can run the benchmark methods for the x86 and x64 platforms.
        [Task(platform: BenchmarkPlatform.X86)]
        [Task(platform: BenchmarkPlatform.X64)]
        public double Foo()
        {
            int sum = 0;
            // x86: IntPtr.Size == 4
            // x64: IntPtr.Size == 8
            for (int i = 0; i < IntPtr.Size; i++)
                sum += i;
            return sum;
        }
    }
}