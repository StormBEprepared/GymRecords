using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GymRecords.Core;

namespace GymRecords.MVVM.viewmodel
{
    internal class MainViewModel : ObservableObject
    { //Icons:https://icons8.com/icon/set/save/color-glass
        /*Commands*/
        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand ShutDownWindowCommand { get; set; }
        public RelayCommand MaximizeWindowCommand { get; set; }
        public RelayCommand MinimizeWindowCommand { get; set; }
        public RelayCommand ShowWelcomePageView { get; set; }
        public RelayCommand ShowHomeView { get; set; }
        public RelayCommand ShowPlanView { get; set; }
        public RelayCommand ShowRecordsView { get; set; }
        public RelayCommand ShowWorkoutView { get; set; }
        public RelayCommand ShowLearnYourselfView { get; set; }
        

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChange();
            }

        }

        public WelcomePageViewModel WelcomePageVM { get; set; }
        public WorkoutViewModel WorkoutVM { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public RecordsViewModel RecordsVM { get; set; }
        public PlanViewModel PlanVM { get; set; }
        public LearnYourselfViewModel LearnYourselfVM { get; set; }

        public MainViewModel()
        {
            WelcomePageVM = new WelcomePageViewModel();
            HomeVM = new HomeViewModel();
            RecordsVM = new RecordsViewModel();
            PlanVM = new PlanViewModel();
            WorkoutVM = new WorkoutViewModel();
            LearnYourselfVM = new LearnYourselfViewModel();
            CurrentView = WelcomePageVM;

            Application.Current.MainWindow.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;


            MoveWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
            ShutDownWindowCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            MaximizeWindowCommand = new RelayCommand(o => {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                }
                else
                {
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                }
            });

            MinimizeWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.WindowState = WindowState.Minimized; });

            ShowHomeView = new RelayCommand(o => { CurrentView = HomeVM; });
            ShowWorkoutView = new RelayCommand(o => { CurrentView = WorkoutVM; });
            ShowRecordsView = new RelayCommand(o => { CurrentView = RecordsVM; });
            ShowPlanView = new RelayCommand(o => { CurrentView = PlanVM; });
            ShowWelcomePageView = new RelayCommand(o => { CurrentView = WelcomePageVM; });
            ShowLearnYourselfView = new RelayCommand(o => { CurrentView = LearnYourselfVM; });
        }
    }
}
