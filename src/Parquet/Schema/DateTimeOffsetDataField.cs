﻿using System;

namespace Parquet.Schema {
    /// <summary>
    /// Schema element for <see cref="DateTime"/> which allows to specify precision
    /// </summary>
    public class DateTimeOffsetDataField : DataField {
        /// <summary>
        /// IsAdjustedToUTC
        /// </summary>
        public bool IsAdjustedToUTC { get; }
        
        /// <summary>
        /// TimeUnit
        /// </summary>
        public DateTimeTimeUnit Unit { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeDataField"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="isAdjustedToUTC"></param>
        /// <param name="unit"></param>
        /// <param name="isNullable"></param>
        /// <param name="isArray"></param>
        /// <param name="propertyName">When set, uses this property to get the field's data.  When not set, uses the property that matches the name parameter.</param>
        public DateTimeOffsetDataField(string name, bool isAdjustedToUTC = true, DateTimeTimeUnit? unit = null, bool? isNullable = null, bool? isArray = null, string? propertyName = null)
           : base(name, typeof(DateTimeOffset), isNullable, isArray, propertyName) {
            IsAdjustedToUTC = isAdjustedToUTC;
            Unit = unit ?? DateTimeTimeUnit.Millis;
        }
    }
}