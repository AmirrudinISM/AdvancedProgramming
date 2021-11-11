using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2036.Models {
    public class Employee036 {
        public string EmpId {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public string Position {
            get;
            set;
        }

        public string Campus {
            get;
            set;
        }

        public double Salary {
            get;
            set;
        }

        public double Deduction {
            get {
                if(Salary < 8000) {
                    return 0.005 * Salary;
                }
                else {
                    return 0.01 * Salary;
                }
            }
            set { }
        }
    }
}
