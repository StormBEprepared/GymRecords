using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRecords.MVVM.viewmodel
{
    internal class PlanViewModel
    {
        //Make a way that the Plan will be saved within a local database for example:
        //Search for the logged in user by it's username then searc the database:
        //var user =
        //from username in accounts
        //where username = "Given Username"
        //select username

        //if username is found and user is logged in under the given username then search in the PlanInfo table in the DataBase.

        //DB row example:
        /*
         * Username: "Given Username"
         * Monday_Cardio_Bool: Yes
         * Monday_Cardio_Text: etcetcetc
         * Monday_Workout_Bool: Yes 
         * Monday_Workout_Text: etcetctec
         * 
         */
    }
}
