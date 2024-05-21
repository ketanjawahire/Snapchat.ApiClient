using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapchat.ApiClient
{
    /// <summary>
    /// ReportDimensionContraints.
    /// </summary>
    public static class ReportDimensionConstants
    {
#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable SA1401 // Fields should be private

        /// <summary>
        /// Country.
        /// </summary>
        public static string Country = "country";

        /// <summary>
        /// CountryAndOs.
        /// </summary>
        public static string CountryAndOs = "country,os";

        /// <summary>
        /// dma.
        /// </summary>
        public static string DMA = "dma";

        /// <summary>
        /// Gender.
        /// </summary>
        public static string Gender = "gender";

        /// <summary>
        /// Age.
        /// </summary>
        public static string Age = "age";

        /// <summary>
        /// AgeAndGender.
        /// </summary>
        public static string AgeAndGender = "age,gender";

        /// <summary>
        /// Os.
        /// </summary>
        public static string Os = "os";

        /// <summary>
        /// Make.
        /// </summary>
        public static string Make = "make";

        /// <summary>
        /// LifestyleCategory.
        /// </summary>
        public static string LifestyleCategory = "lifestyle_category";

#pragma warning restore SA1401 // Fields should be private
#pragma warning restore CA2211 // Non-constant fields should not be visible
    }
}
