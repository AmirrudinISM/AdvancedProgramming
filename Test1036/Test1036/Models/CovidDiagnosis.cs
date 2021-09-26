using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1036.Models
{
    public class CovidDiagnosis
    {
        public string Name
        {
            get;
            set;
        } 

        public string PhoneNumber
        {
            get;
            set;
        }

        public bool Fever
        {
            get;
            set;
        }

        public bool DryCough
        {
            get;
            set;
        }

        public bool BreathingDifficulty
        {
            get;
            set;
        }

        public bool PersonUnderInvestigation
        {
            get;
            set;
        }

        public bool CloseContact
        {
            get;
            set;
        }

        public string RiskLevel
        {
            get;
        }

        public string DetermineRiskLevel
        {
            get
            {
                if ((Fever == true && DryCough == true && BreathingDifficulty == true) || ((Fever == true || DryCough == true || BreathingDifficulty == true) && (PersonUnderInvestigation == true || CloseContact == true)))
                {
                    
                    return "High";
                }
                else if ((Fever == true || DryCough == true || BreathingDifficulty == true))
                {
                    
                    return "Medium";
                }
                else
                {
                    
                    return "Low";
                }
            }
        }
    }
}
