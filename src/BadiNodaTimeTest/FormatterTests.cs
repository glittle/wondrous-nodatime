﻿// Copyright 2017 Glen Little. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.

using BadiNodaTime;
using Xunit;

namespace BadiNodaTimeTest
{
  public class FormatterTests
  {
    [Theory]
    [InlineData(180, 10, 10, "180-10-10")]
    [InlineData(180, 18, 19, "180-18-19")]
    [InlineData(180, 0, 3, "180-0-3")]
    [InlineData(180, 19, 1, "180-19-1")]
    public void ToString_Default(int year, int month, int day, string result)
    {
      new BadiDate(year, month, day).ToString().ShouldEqual(result);
    }


    [Theory]
    [InlineData(180, 10, 10, "2023-9-17")]
    [InlineData(180, 18, 19, "2024-2-25")]
    [InlineData(180, 0, 3, "2024-2-28")]
    [InlineData(180, 19, 1, "2024-3-1")]
    public void ToString_G(int year, int month, int day, string result)
    {
      new BadiDate(year, month, day).ToString("{gregorian.year}-{gregorian.month}-{gregorian.day}").ShouldEqual(result);
    }


    [Theory]
    [InlineData(180, 10, 9, "{day00} {month_meaning} {yearOfEra}", "09 Might 180")]
    [InlineData(180, 10, 9, "{day} {month_arabic} {yearOfEra}", "9 `Izzat 180")]
    [InlineData(180, 10, 9, "{day} {month_arabic} {yearOfUnity}", "9 `Izzat 9")]
    [InlineData(180, 10, 9, "{day_meaning} {month_meaning} {yearOfUnity}", "Names Might 9")]
    [InlineData(180, 10, 9, "{unity} {allThings}", "10 1")]
    [InlineData(180, 10, 9, "{yearOfUnity00} {yearOfUnity_meaning} {yearOfUnity_arabic}", "09 Splendor Bahá")]
    [InlineData(180, 10, 9, "{weekday} {weekday00} {weekday_meaning} {weekday_arabic}", "1 01 Glory Jalál")]
    [InlineData(180, 10, 9, "{weekday_arabic}/{weekday_meaning} ({element_meaning}) in the {yearOfUnity_ordinal} year of the {unity_ordinal} Unity.", "Jalál/Glory (Water) in the nineth year of the tenth Unity.")]
    [InlineData(180, 10, 9, "{element} {element_meaning}", "3 Water")]
    [InlineData(180, 10, 9, "{unknown} {day}", "{unknown} 9")]
    [InlineData(180, 10, 9, "{month_meaning} {yearOfEra} overlaps {gregorian.month_latin_long} {gregorian.year}", "Might 180 overlaps September 2023")]
    public void DateToString(int year, int month, int day, string format, string result)
    {
      new BadiDate(year, month, day).ToString(format).ShouldEqual(result);
    }

  }
}
