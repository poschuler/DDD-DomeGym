using DomeGym.Domain.UnitTests.TestConstants;

namespace DomeGym.Domain.UnitTests.TestUtils.Participants;

public class ParticipantFactory
{
    public static Participant CreateParticipant(Guid? id = null, Guid? userId = null)
    {
        return new Participant(
            userId: userId ?? Constants.User.Id,
            id: id ?? Constants.Participant.Id
            );
    }
    
}
