using System;

namespace _4_Company_Hierarchy
{
    internal interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        ProjectState State { get; set; }
        void CloseProject();
        string ToString();
    }
}