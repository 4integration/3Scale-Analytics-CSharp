/*
 * M3ScaleAnalytics.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 11/17/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using M3ScaleAnalytics.PCL;

namespace M3ScaleAnalytics.PCL.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PeriodEnum
    {
        YEAR, //TODO: Write general description for this method
        MONTH, //TODO: Write general description for this method
        WEEK, //TODO: Write general description for this method
        DAY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PeriodEnum
    /// </summary>
    public static class PeriodEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "year", "month", "week", "day" };

        /// <summary>
        /// Converts a PeriodEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PeriodEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PeriodEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PeriodEnum.YEAR:
                case PeriodEnum.MONTH:
                case PeriodEnum.WEEK:
                case PeriodEnum.DAY:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PeriodEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PeriodEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PeriodEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into PeriodEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PeriodEnum value</returns>
        public static PeriodEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type PeriodEnum", value));

            return (PeriodEnum) index;
        }
    }
} 