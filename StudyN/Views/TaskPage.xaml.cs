﻿using StudyN.ViewModels;

namespace StudyN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPage : ContentPage
    {
        public TaskPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new TaskDataViewModel();
        }

        TaskDataViewModel ViewModel { get; }

    }
}