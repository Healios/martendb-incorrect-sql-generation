namespace Incorrect_SQL_generation
{
    public record Participant(Guid Id, string Name);

    public record Event(Guid Id, string Name, string Summary, string Description, List<Participant> Participants);
}
