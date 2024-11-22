using System;
using ErrorOr;

namespace DomeGym.Domain.SessionAggregate;

public static class SessionErrors
{
    public static Error CannotCancelReservationTooCloseToSession = Error.Validation(
        code: "Session.CannotCancelReservationTooCloseToSession",
        description: "Cannot cancel reservation less than 24 hours before session");

    public static Error ParticipantNoFoundInSession = Error.Validation(
        code: "Session.CannotParticipantNoFoundInSession",
        description: "Participant not found in session");

    public static Error CannotHaveMoreReservationsThanParticipants = Error.Validation(
        code: "Session.CannotHaveMoreReservationsThanParticipants",
        description: "Cannot have more reservation than participants");

}
