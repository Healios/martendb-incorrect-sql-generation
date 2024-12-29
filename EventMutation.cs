using Marten;

namespace Incorrect_SQL_generation
{
    [MutationType]
    public class EventMutation
    {
        public async Task<IEnumerable<Event>> CreateDemoEvents([Service] IDocumentSession session, CancellationToken cancellationToken)
        {
            var event1 = new Event(Guid.NewGuid(), "Should gaming advertisements be banned?", "77% of Americans believe that gambling ads should be banned. But is there political support?", "A poll from The New Yorker shows that 77% of Americans believe that gambling advertisements should be banned. But is there political support for the same? Our moderator Thomas Glover (NEWS & Co) asks politicians about this. \nIn 2022, a study showed that 478,000 people aged 18 to 79 have had gambling problems to a greater or lesser extent within the past year. This is more than doubling since 2016. Something must be done to stem the increasing number of gambling addicts. \nBut are gambling advertisements even worth focusing on in this context? In 2021, 1,147 gambling advertisements were placed daily in American media, and around half a billion dollars is spent annually on marketing. We talk to both researchers and the gaming industry about the impact and influence of advertisements.", new List<Participant>
            {
                new Participant(Guid.NewGuid(), "Carla Valentine"),
                new Participant(Guid.NewGuid(), "Domingo Suarez")
            });
            var event2 = new Event(Guid.NewGuid(), "How outdoor life wins over screens and the well-being crisis", "Our children are lonelier than ever before. We want to change that!", "Children today spend less time in nature and the garden, but more and more time in front of a screen or simply indoors. Many are escorted to and from school, to sports and often only watch nature on television or from the car. Today, children between the ages of 8-18 spend an average of 6.5 hours a day with electronic media - and they are lonelier than ever before. Join us in debating an important part of the solution - how nature and community can contribute to solving the well-being crisis among children and young people. \\nShould we as parents also learn to let go? Where is the line between dangerous and educational activity? Experience scouts performing \"dangerous things you should let your child try\" during the debate. \\n \\nCan a meaningful community in nature make children and young people happier, create greater belonging and give meaning to life in a different way? \\nHow can we collaborate so that more children and young people can have access to nature experiences and formative communities?", new List<Participant>
            {
                new Participant(Guid.NewGuid(), "Martin Riggs"),
                new Participant(Guid.NewGuid(), "Ava Martinez"),
                new Participant(Guid.NewGuid(), "Gary Oldman")
            });
            var event3 = new Event(Guid.NewGuid(), "Agencies and consultancy on corporate sustainability", "How can agencies both acquire competencies and live up to their role?", "Stories about product and company sustainability are becoming increasingly grandiose. Behind the claims are often advertising and communications agencies that advise companies on the messages. But are the agencies really equipped to advise their clients on the connection between reality and statements?\n\nCan consumers trust that they will receive “sustainability” based on these claims? Shouldn’t professionals in the value chain move from what you “shouldn’t” do to how you “should” do it when it comes to creating real sustainable progress? \n\nAgencies are central to communicating product sustainability. They can create real change if they manage to develop as advisors on sustainability. Will agencies take responsibility, and how can they do so? Can agencies advise on sustainability stories if they themselves do not live up to them? \n\nGRAKOM is preparing an ESG code for agencies with a supporting ESG advisor training. What should a code contain?", new List<Participant>
            {
                new Participant(Guid.NewGuid(), "Tom Cruise"),
                new Participant(Guid.NewGuid(), "Penelope Cruz")
            });
            var event4 = new Event(Guid.NewGuid(), "Should children be better protected from unhealthy marketing?", "Three health organizations are fighting against unhealthy marketing.", "The vast majority of food advertisements are for unhealthy products and are found especially on social media, where children and young people hang out. The massive marketing influences what consumers buy. Today, children and young people get four times as much sugar per day as recommended. Approximately one in five 14-15 year olds is overweight, and the trend is going in the wrong direction. \n\nThe Diabetes Association, the Heart Association and the Cancer Society work together to protect children and young people under the age of 18 from marketing of unhealthy foods. We show examples of the advertisements that children and young people are exposed to, and Gordon Ngoui, president of the Cancer Society, directs the course of the battle. In addition to the three NGOs, representatives of the government, industry, tech giants and American Schoolchildren answer whether it is a problem that children and young people are exposed to unhealthy marketing. What should we do about it? Who is responsible?\n\nAlong the way, the audience expresses their opinion by voting on various questions.", new List<Participant>
            {
                new Participant(Guid.NewGuid(), "Dennis Villeneuve"),
            });
            var events = new List<Event> { event1, event2, event3, event4 };

            session.Store(events.ToArray());
            await session.SaveChangesAsync();

            return events;
        }
    }
}
