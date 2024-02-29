﻿using System.ComponentModel.DataAnnotations;

namespace CodedByKay.BondBridge.Models.Attributes
{
    public class NotDefaultGuidAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is Guid guidValue)
            {
                return guidValue != Guid.Empty;
            }
            return false;
        }
    }
}
