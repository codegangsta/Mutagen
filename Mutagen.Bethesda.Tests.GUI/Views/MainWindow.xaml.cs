﻿using Loqui;
using MahApps.Metro.Controls;
using Noggog;
using Noggog.WPF;
using System;
using System.Threading.Tasks;

namespace Mutagen.Bethesda.Tests.GUI.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : MetroWindow
{
    public MainWindow()
    {
        InitializeComponent();
        Task.Run(LoquiRegistration.SpinUp).FireAndForget();
        var vm = this.WireMainVM<MainVM>($"Settings.json");
        if (Environment.GetCommandLineArgs().Contains("Start"))
        {
            vm.RunAllCommand.Execute();
        }
    }
}