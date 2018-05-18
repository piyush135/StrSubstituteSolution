using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace StringSubstitutesTest.TestData
{
    public static class StringSubStituteMockData
    {
        public static string Prefix = "%";
        public static string DifferentPrefix = "{";

        public static string SurFix = "%";
        public static string DifferentSurFix = "}";

        public static Dictionary<string, int> ValueMap
        {
            get
            {
                var dicts = new Dictionary<string, int>();
                dicts.Add("amount", 1000);
                dicts.Add("loan", 10000);
                dicts.Add("lease", 200000);
                dicts.Add("ROI", 10);
                dicts.Add("month", 12);

                return dicts;
            }
        }

        public static Dictionary<string, int> DifferntValueMapFromSource
        {
            get
            {
                var dicts = new Dictionary<string, int>();
                dicts.Add("Amount", 1000);
                dicts.Add("loan", 10000);
                dicts.Add("lease", 200000);
                dicts.Add("ROI", 10);
                dicts.Add("Month", 12);

                return dicts;
            }
        }

        public static string GetSource()
        {
            return "The amount of car is %amount%. The loan amount can be granted is %loan%.The lease of the car will be %lease%. The rate of interest for loan will be %ROI% for %month%.";
        }

        public static string GetSourceForDiffernetPrefix()
        {
            return "The amount of car is {amount%. The loan amount can be granted is {loan%.The lease of the car will be {lease%. The rate of interest for loan will be {ROI% for {month%.";
        }

        public static string GetSourceForDiffernetSurfix()
        {
            return "The amount of car is %amount}. The loan amount can be granted is %loan}.The lease of the car will be %lease}. The rate of interest for loan will be %ROI} for %month}.";
        }

        public static string GetSourceForDiffernetPurfixAndSurfix()
        {
            return "The amount of car is {amount}. The loan amount can be granted is {loan}.The lease of the car will be {lease}. The rate of interest for loan will be {ROI} for {month}.";
        }

        public static string GetOutPutSource()
        {
            return
                "The amount of car is 1000. The loan amount can be granted is 10000.The lease of the car will be 200000. The rate of interest for loan will be 10 for 12.";
        }

        public static string DiffernetOutPutSource()
        {
            return "The amount of car is %amount%. The loan amount can be granted is 10000.The lease of the car will be 200000. The rate of interest for loan will be 10 for %month%.";
        }

        public static string DiffernetOutPutSourcefromPrefix()
        {
            return
                "The amount of car is {amount%. The loan amount can be granted is {loan%.The lease of the car will be {lease%. The rate of interest for loan will be {ROI% for {month%.";
        }

        public static string DiffernetOutPutSourcefromSurfix()
        {
            return
                "The amount of car is %amount}. The loan amount can be granted is %loan}.The lease of the car will be %lease}. The rate of interest for loan will be %ROI} for %month}.";
        }
    }
}