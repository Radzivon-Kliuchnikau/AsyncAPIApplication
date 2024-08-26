using System.Text.Json.Serialization;
using AsyncAPIApplication.Data;
using AsyncAPIApplication.Models;
using AsyncAPIApplication.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite("Data Source=SqliteDbStore.db");
});

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

app.UseHttpsRedirection();

//Starting endpoint
app.MapPost("api/v1/supplies", async (ApplicationDbContext dbContext, ListOfRequests listOfRequests) =>
{
    if (listOfRequests == null)
    {
        return Results.BadRequest();
    }

    listOfRequests.StatusOfRequest = "ACCEPTED";
    listOfRequests.EstimatedTimeToCompleteTheTask = "2024-08-26:17:00:00";

    await dbContext.Requests.AddAsync(listOfRequests);
    await dbContext.SaveChangesAsync();

    return Results.Accepted($"api/v1/suppliesrequeststatus/{listOfRequests.RequestId}", listOfRequests);
});

app.Run();
