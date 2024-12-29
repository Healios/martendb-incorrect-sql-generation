using Marten;

namespace Incorrect_SQL_generation
{
    [QueryType]
    public class EventQuery
    {
        public IExecutable<Event> WebStyleSearchCorrect([Service] IQuerySession session, CancellationToken cancellationToken) =>
            session.Query<Event>()
                .Where(pEvent => pEvent.WebStyleSearch("Marketing OR Sustainability"))
                .AsExecutable();

        public IExecutable<Event> ParticipantFilterCorrect([Service] IQuerySession session, CancellationToken cancellationToken) =>
            session.Query<Event>()
                .Where(pEvent => !pEvent.Participants.Any(participant => !participant.Name.StartsWith("D")))
                .AsExecutable();

        public IExecutable<Event> SummaryOrParticipantCorrect([Service] IQuerySession session, CancellationToken cancellationToken) =>
            session.Query<Event>()
                .Where(pEvent => pEvent.Summary.StartsWith("77%") || !pEvent.Participants.Any(participant => !participant.Name.StartsWith("D")))
                .AsExecutable();

        public IExecutable<Event> SummaryAndParticipantIncorrect([Service] IQuerySession session, CancellationToken cancellationToken) =>
            session.Query<Event>()
                .Where(pEvent => pEvent.Summary.StartsWith("77%") && !pEvent.Participants.Any(participant => !participant.Name.StartsWith("D")))
                .AsExecutable();

        public IExecutable<Event> WebStyleSearchAndParticipantIncorrect([Service] IQuerySession session, CancellationToken cancellationToken) =>
            session.Query<Event>()
                .Where(pEvent => pEvent.WebStyleSearch("Marketing OR Sustainability") && !pEvent.Participants.Any(p => !p.Name.StartsWith("D")))
                .AsExecutable();
    }
}
