using System;
using DomeGym.Domain.Common;

namespace DomeGym.Domain.SessionAggregate;

public class Reservation : Entity
{
    public Reservation(Guid participantId, Guid? id = null)
    : base(id ?? Guid.NewGuid())
    {
        ParticipantId = participantId;
    }

    public Guid ParticipantId { get; }
}
