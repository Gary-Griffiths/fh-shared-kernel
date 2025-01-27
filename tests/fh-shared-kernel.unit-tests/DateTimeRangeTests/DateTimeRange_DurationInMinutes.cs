﻿using FluentAssertions;

namespace FamilyHubs.SharedKernel.UnitTests.DateTimeRangeTests;

public class DateTimeRange_DurationInMinutes
{
    [Fact]
    public void Returns60GivenOneHourDifference()
    {
        var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));

        dtr.DurationInMinutes().Should().Be(60);
    }
}
