﻿using System;
using System.Collections.Generic;
using System.Windows;
using OxyPlot;
using OxyPlot.Fluent;
using OxyPlot.Fluent.Wpf;

namespace WpfSample
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Window window = Figure.Configure()
                .WithPlot()
                .WithTitle("Sample Plot")
                .WithLine(GetData())
                .Plot
                .Figure
                .Build()
                .AsWindow();

            window.ShowDialog();
        }

        private static IEnumerable<DataPoint> GetData()
        {
            yield return new DataPoint(0, 0);
            yield return new DataPoint(4, 3);
            yield return new DataPoint(6, 6);
            yield return new DataPoint(7.4, 3);
            yield return new DataPoint(8, 2);
        }
    }
}