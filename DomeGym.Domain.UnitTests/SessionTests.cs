using DomeGym.Domain.UnitTests.TestUtils.Participants;
using DomeGym.Domain.UnitTests.TestUtils.Sessions;
using FluentAssertions;

namespace DomeGym.UnitTests;

public class SessionTests
{
    [Fact]
    public void ReserveSpot_WhenNoMoreRoom_ShouldFailReservation()
    {
        // Arrange
        //Create a session with a maximum participant of 1
        var session = SessionFactory.CreateSession(maxParticipants: 1);
        //Create 2 participants        
        var participant1 = ParticipantFactory.CreateParticipant(id: Guid.NewGuid(), userId: Guid.NewGuid());
        var participant2 = ParticipantFactory.CreateParticipant(id: Guid.NewGuid(), userId: Guid.NewGuid());

        // Act
        //add participant 1
        session.ReserveSpot(participant1);
        //add participant 2
        var action = () => session.ReserveSpot(participant2);

        // Assert
        //participant 2 reservation failed
        action.Should().ThrowExactly<Exception>();
    }
}