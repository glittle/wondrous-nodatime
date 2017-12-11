﻿// Copyright 2017 Glen Little. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.

using System;
using System.Collections.Generic;
using WondrousNodaTime;
using NUnit.Framework;
using NodaTime;

namespace WondrousNodaTime.Test
{
  public partial class CoreTest
  {
    [Test]
    public void CreateDate()
    {
      Assert.AreEqual(Wondrous.CreateDate(180, 10, 10).ToWondrousString(), "180-10-10");
      Assert.AreEqual(Wondrous.CreateDate(180, 18, 19).ToWondrousString(), "180-18-19");
      Assert.AreEqual(Wondrous.CreateDate(180, 0, 3).ToWondrousString(), "180-0-3");
      Assert.AreEqual(Wondrous.CreateDate(180, 19, 1).ToWondrousString(), "180-19-1");
    }

    [Test]
    public void EnsureIsWondrous ()
    {
      Assert.Throws<ArgumentException>(() => new LocalDate(2000,1,1).ToWondrousString());
    }

}
}