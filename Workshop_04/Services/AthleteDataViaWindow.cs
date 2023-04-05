﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTGUI_GYAK04.Services
{
    public class AthleteDataViaWindow : IAthleteDataService
    {
        public void ShowData(Athlete athlete)
        {
            new AthleteDataWindow(athlete).ShowDialog();
        }
    }
}
