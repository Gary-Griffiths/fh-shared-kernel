﻿using MediatR;

namespace FamilyHubs.SharedKernel;

/// <summary>
/// Integration events are used to communicate between bounded contexts and/or applications.
/// They are often mapped from domain events in the notifying system 
/// and sometimes to domain events in the consuming system
/// </summary>
public abstract class IntegrationEventBase : INotification
{
    public DateTimeOffset DateOccurred { get; protected set; } = DateTime.UtcNow;
    string? EventType { get; } = default!;

}
