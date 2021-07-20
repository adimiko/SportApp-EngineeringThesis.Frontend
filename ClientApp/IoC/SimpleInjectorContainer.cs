using ClientApp.GUI.Extensions;
using ClientApp.GUI.Forms;
using ClientApp.RestApiClient.Endpoints.V1.Accounts;
using ClientApp.RestApiClient.Endpoints.V1.BodyMeasurements;
using ClientApp.RestApiClient.Endpoints.V1.CompletedWorkouts;
using ClientApp.RestApiClient.Endpoints.V1.CustomWorkoutRoutines;
using ClientApp.RestApiClient.Endpoints.V1.Errors;
using ClientApp.RestApiClient.Endpoints.V1.ExerciseInfo;
using ClientApp.RestApiClient.Endpoints.V1.Identity;
using ClientApp.RestApiClient.Endpoints.V1.SampleWorkoutRoutines;
using ClientApp.RestApiClient.Endpoints.V1.WorkoutsAnalysis;
using ClientApp.RestApiClient.Endpoints.V1.WorkoutsStats;
using ClientApp.RestApiClient.Settings;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.IoC
{
    public class SimpleInjectorContainer
    {
        public static Container GetContainer()
        {
            var container = new Container();


            container.Register<IBodyMeasurementsRestClient, BodyMeasurementsRestClient>(); 
            container.Register<IAccountsRestClient, AccountsRestClient>();

            container.Register<IIdentityRestClient, IdentityRestClient>();
            container.Register<IApiErrorHandler, ApiErrorHandler>(); 
            container.Register<IMessenger, Messenger>(); 
            container.Register<ISampleWorkoutRoutineRestClient, SampleWorkoutRoutineRestClient>();
            container.Register<ICustomWorkoutRoutineRestClient, CustomWorkoutRoutineRestClient>(); 
            container.Register<ICompletedWorkoutRestClient, CompletedWorkoutRestClient>();
            container.Register<IExerciseInfoRestClient, ExerciseInfoRestClient>(); 
            container.Register<IWorkoutsStatsRestClient, WorkoutsStatsRestClient>();
            container.Register<IWorkoutsAnalysisRestClient, WorkoutsAnalysisRestClient>();
            AutoRegisterWindowsForms(container);
            container.Verify();

            return container;
        }

        private static void AutoRegisterWindowsForms(Container container)
        {
            var types = container.GetTypesToRegister<Form>(typeof(MainMenuForm).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, container);

                registration.SuppressDiagnosticWarning(
                    DiagnosticType.DisposableTransientComponent,
                    "Forms should be disposed by app code; not by the container.");

                container.AddRegistration(type, registration);
            }
        }
    }
}
