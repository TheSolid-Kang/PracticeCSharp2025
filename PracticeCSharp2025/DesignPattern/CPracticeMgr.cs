using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeCSharp2025.CPractice;

namespace PracticeCSharp2025.DesignPattern
{
    public class CPracticeMgr
    {
        public static CPracticeMgr GetInstance { get; } = new CPracticeMgr();
        private CPractice.CPractice practice;

        private CPracticeMgr() { }
        public void SetPractice()
        {

        }

    }
}
