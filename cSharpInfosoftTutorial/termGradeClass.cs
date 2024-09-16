using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    class termGradeClass
    {
        public double firstExam, secondExam, thirdExam, finalExam;
        public termGradeClass(double firstExam, double secondExam, double thirdExam, double finalExam)
        {
            this.firstExam = firstExam;
            this.secondExam = secondExam;
            this.thirdExam = thirdExam;
            this.finalExam = finalExam;
        }
        public double getResult()
        {
            return (firstExam + secondExam + thirdExam + finalExam) / 4;
        }
        public string highestHonorDialog()
        {
            return "\nCongratualations! you achieved With Highest Honor award!";
        }
        public string highHonorDialog()
        {
            return "\nCongratualations! you achieved With High Honor award!";
        }
        public string honorDialog()
        {
            return "\nCongratualations! you achieved With Honor award!";
        }
        public string passedDialog()
        {
            return "\nCongratualations! You Passed";
        }
        public string failedDialog()
        {
            return "\nYou Failed.";
        }
    }
}
