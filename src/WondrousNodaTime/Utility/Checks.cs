﻿// Copyright 2017 Glen Little. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.
using NodaTime;
using System;

namespace WondrousNodaTime.Utility
{
  internal class Checks
  {
    internal static void EnsureIsWondrousCalendar(string paramName, LocalDate date)
    {
      if (date.Calendar != CalendarSystem.Wondrous)
      {
        throw new ArgumentException("Can only be used with a LocalDate with the Wondrous calendar system", paramName);
      }
    }
  }
}