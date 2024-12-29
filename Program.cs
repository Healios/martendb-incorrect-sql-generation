using Marten;
using Weasel.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMarten(options =>
{
    options.Connection(builder.Configuration.GetConnectionString("MARTEN")!);
    options.UseNewtonsoftForSerialization(enumStorage: EnumStorage.AsString, nonPublicMembersStorage: NonPublicMembersStorage.All);

    if (builder.Environment.IsDevelopment()) options.AutoCreateSchemaObjects = AutoCreate.All;
})
.UseLightweightSessions();

builder.Services.AddGraphQLServer().AddIncorrect_SQL_generationTypes();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapGraphQL();
app.Run();
