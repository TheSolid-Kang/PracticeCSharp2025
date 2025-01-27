using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeCSharp2025.Practice;

namespace PracticeCSharp2025.DesignPattern
{
    public class CPracticeMgr
    {
        public enum PRACTICE
        {
            NOTION_API = 0
            , KMA_API
            , END
        }

        private CPracticeMgr() { }


        public static CPracticeMgr GetInstance { get; } = new CPracticeMgr();
        private CPractice practice = null;


        public void SetPractice(PRACTICE _selectdPractice = PRACTICE.NOTION_API)
        {
            if (practice != null)
            {
                practice.Release();
                practice = null;
            }
            switch (_selectdPractice)
            {
                case PRACTICE.NOTION_API:
                    practice = new CPracticeNotionApiModule();
                    break;
                case PRACTICE.KMA_API:
                    practice = new CPracticeKmaApiModule();
                    break;
                case PRACTICE.END:

                    break;
                default:

                    break;
            }
        }
        public CPractice GetPractice() { return practice; }

    }
}
